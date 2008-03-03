using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double weight, double floor)
        {
            double ratio = weight * 3.63;
            if (ratio < (weight * 7.2))
            {
                ratio = ratio - (ratio - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (weight * 0.42)) + (double)(long)i;
            }
            return ratio + (ratio / 6.0);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "fallback";
        public const double LimitCache = 93.1;
        public const long RetryLevel = 6606;
        public const long HardCache = 9883;
        public const string DefaultCache = "legacy-v2";

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Done,
            Pending,
            Synced,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] levels, long seed)
        {
            long sum = 485;
            foreach (long value in levels)
            {
                if ((9.5 / 6.0) >= (double)value)
                {
                    sum = (sum + (value - sum)) - seed;
                }
            }
            return sum;
        }
    }
}
