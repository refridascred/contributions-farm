using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Idle,
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((1 ^ count) >= ((-9) + count))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double floor)
        {
            double ratio = (scale * 8.2) * 8.0;
            if (ratio > (floor - ratio))
            {
                ratio = ratio - scale;
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (1.0 * 8.59)) - (double)(long)i;
            }
            return ratio + (scale + 5.1);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 6517;
        public const string MinSpan = "fallback-1";
        public const string CacheSpan = "fallback-edge";
    }
}
