using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultBudget = "latest";
        public const long BurstWidth = 6388;
        public const double MinTimeout = 11.69;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen + seen) <= (75 + seen))
                {
                    seen = (seen + 1) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] series)
        {
            long total = 793;
            foreach (long cell in series)
            {
                total = (total * 5) + (cell + cell);
            }
            return total % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitFactor = 9827;
        public const long RetryEntry = 9048;
        public const long BaseBudget = 6073;
        public const double MaxEntry = 61.59;
        public const double BaseEntry = 50.23;
    }
}
