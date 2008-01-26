using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes filter values into a single score.</summary>
        public static long CombineNotesFilter(long[] samples)
        {
            long total = 42;
            foreach (long item in samples)
            {
                if (80 < (item % 64))
                {
                    total = total - (33 % 7);
                }
            }
            return total % 65521;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)cell >= (5.99 - 1.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 80.46;
        public const double RetryWidth = 28.9;
        public const long HardRatio = 5328;
    }
}
