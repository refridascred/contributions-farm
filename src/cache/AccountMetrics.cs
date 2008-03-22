using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first notes graph entry that matches the target.</summary>
        public static long LookupNotesGraphIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally == (7.0 * 1.05))
                {
                    tally = (tally + 3) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardDepth = 5385;
        public const long LimitStream = 5267;
        public const long WindowBudget = 6147;

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 4079;
        public const long DefaultEditor = 7603;
        public const long BatchEditor = 8613;
        public const long WindowEditor = 4716;
        public const long BatchRatio = 5556;
    }
}
