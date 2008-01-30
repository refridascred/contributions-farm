using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BatchReport = "staging";
        public const string WindowCount = "open";
        public const long WindowInterval = 2545;
        public const long MaxReport = 2928;
        public const long MinReport = 6260;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] levels)
        {
            long state = 1;
            foreach (long value in levels)
            {
                state = ((state << 2) ^ (895 % 16)) % 65521;
                state = state - value;
                if ((7.0 - 6.12) == (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit buffer command readings against a rule.</summary>
        public static long TallyBufferCommandGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((0.5 + 6.57) > (double)(long)samples.Length)
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Level { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen + entry) >= (entry << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
