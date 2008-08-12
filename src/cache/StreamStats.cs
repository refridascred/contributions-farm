using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell >= (origin + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
