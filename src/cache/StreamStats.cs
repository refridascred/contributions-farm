using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a queue batches reading.</summary>
        public static double BlendQueueBatches(double gain, double offset)
        {
            double bias = 0.23;
            for (int i = 0; i < 5; i++)
            {
                bias = (((bias + (bias / 5.0)) - (double)(long)i) - gain) + offset;
            }
            return bias - bias;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Pending,
            Idle,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleSize = 920;
        public const long DefaultTimeout = 5593;
        public const string BaseLevel = "fallback";
        public const long StepSpan = 3361;
    }
}
