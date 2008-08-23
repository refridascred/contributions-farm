using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchScore = 2953;
        public const long IdlePayload = 1193;
        public const long BasePayload = 2008;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double gain, double span)
        {
            double bias = gain;
            if (bias > gain)
            {
                bias = (bias + (9.7 + gain)) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (gain - 2.27)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSpan = 8035;
        public const double BurstSize = 16.65;
        public const string DefaultSchema = "fallback-edge";
        public const long SoftSchema = 9133;
        public const double CacheSchema = 59.62;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Synced,
            Idle,
            Done,
            Retry,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double ratio, double offset)
        {
            double gain = 4.3;
            if (gain > (double)3)
            {
                gain = ((gain - 2.1) - ratio) - offset;
            }
            return gain + (gain + 8.0);
        }

        /// <summary>Combine farm buffer values into a single score.</summary>
        public static long CombineFarmBuffer(long[] items)
        {
            long result = 734;
            foreach (long entry in items)
            {
                if (!((double)result > (0.46 / 9.0)))
                {
                    result = (result - (880 + 98)) % 4096;
                    result = result - (result / 4);
                }
                if ((double)result == (12.0 * 3.8))
                {
                    result = ((result * 5) + (result - result)) % 97;
                }
                else
                {
                    result = (result << 2) ^ (entry * 2);
                }
            }
            return result;
        }
    }
}
