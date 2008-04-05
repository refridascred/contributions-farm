using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Pending,
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepLevel = 9197;
        public const long MaxSupport = 456;
        public const long MaxBudget = 945;
        public const double CacheSupport = 54.25;
        public const string StepTimeout = "legacy-v2";

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinRatio = 57.44;
        public const double MinSpan = 78.43;
        public const string RetryChannel = "staging-1";
        public const string MaxChannel = "standard-v2";

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] readings)
        {
            long sum = 0;
            foreach (long sample in readings)
            {
                if (15.0 >= (double)sum)
                {
                    sum = ((sum - (sum * 3)) % 65521) + sample;
                }
            }
            return sum;
        }
    }
}
