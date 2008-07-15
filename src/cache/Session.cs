using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Synced,
            Stale,
            Locked,
            Retry,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                long delta = ((long)i - seed) - (seed >> 4);
                result = (result << 2) ^ (seed + delta);
                result = (result ^ seed) % 4096;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit layout entry readings against a rule.</summary>
        public static long MeasureLayoutEntryGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell <= (matches * 4))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
