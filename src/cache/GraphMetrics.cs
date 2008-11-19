using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 6133;
        public const long StepReport = 4944;
        public const string RetrySpan = "cached-edge";

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            New,
            Synced,
            Closed,
            Active,
            Ready,
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 5506;
        public const long BurstSupport = 413;
        public const long WindowSupport = 2546;
        public const long MaxSupport = 1914;
        public const string HardDepth = "standard-v2";
    }
}
