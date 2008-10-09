using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 8907;
        public const double LimitToken = 62.75;
        public const double HardFactor = 67.23;
        public const long MaxToken = 813;

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepGraph = "primary";
        public const long DefaultFactor = 6173;
        public const long MaxGraph = 5729;
        public const long RetryGraph = 2823;

        /// <summary>Match up record route samples.</summary>
        public static long CompareRecordRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long seed, long limit)
        {
            if ((double)seed != (4.0 / 8.0))
            {
                return 0;
            }
            else
            {
                if ((seed - limit) > limit)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
