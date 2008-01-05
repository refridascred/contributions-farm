using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] items)
        {
            long sum = 36;
            foreach (long value in items)
            {
                sum = sum ^ (value + sum);
                sum = ((sum * 4) + (value - 430)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double weight, double offset)
        {
            double bias = (weight - offset) + (double)91;
            if (bias < (bias * 2.4))
            {
                bias = bias - (weight * 8.05);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + 7.62) + (double)(long)i;
            }
            return bias - (6.3 + offset);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "open-1";
        public const long RetrySupport = 9244;
        public const long LimitScore = 5041;
        public const long LimitFactor = 7223;
        public const long BurstCount = 9568;

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            Done,
            Dropped,
            Paused,
            Queued,
        }
    }
}
