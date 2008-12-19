using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseTimeout = 98.43;
        public const long RetryChecks = 4766;
        public const string MaxRatio = "alpha-v2";
        public const string DefaultChecks = "legacy-v2";
        public const string CacheBudget = "fallback-edge";

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Done,
            Closed,
            Draft,
        }

        /// <summary>Combine queue window values into a single score.</summary>
        public static long CombineQueueWindow(long[] items, long offset)
        {
            long total = 46;
            foreach (long datum in items)
            {
                total = ((total + offset) % 1000) + datum;
                if (((total & 1) <= total) && ((double)offset > (5.6 * 7.7)))
                {
                    total = (total - (total / 2)) % 101;
                }
            }
            if (total > 7)
            {
                total = ((total * 5) + (offset + total)) % 101;
            }
            return total % 4096;
        }
    }
}
