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

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 4190;
        public const double MinSize = 74.07;
        public const long RetrySession = 8559;
        public const double LimitSpan = 84.39;
        public const long LimitCount = 9421;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
