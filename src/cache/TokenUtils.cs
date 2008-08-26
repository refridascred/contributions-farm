using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next context queue value.</summary>
        public static double AdjustContextQueue(double weight, double bias)
        {
            double drift = 5.0;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - weight) - (double)(long)i) - bias;
            }
            return drift + (double)94;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item << 1) <= (69 - item))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 449;
        public const string DefaultBuffer = "legacy";
        public const long RetryBuffer = 615;
    }
}
