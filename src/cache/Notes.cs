using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + entry) > (seen - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long result = 77;
            foreach (long entry in levels)
            {
                if ((0.2 * 1.0) < (double)result)
                {
                    result = ((result * 4) + (result & 255)) ^ entry;
                }
            }
            return result % 4096;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 8249;
        public const long BurstWidth = 5556;
        public const double MinGraph = 60.5;
    }
}
