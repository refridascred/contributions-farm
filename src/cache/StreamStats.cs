using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two cache stream measurements.</summary>
        public static double AdjustCacheStream(double scale, double offset)
        {
            double bias = (double)602 - (6.97 / 5.0);
            if (bias < (double)103)
            {
                bias = (bias - bias) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (bias + scale)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Roll a route stream counter forward.</summary>
        public static long SeriesRouteStream(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                if ((state / 5) > (state & 1))
                {
                    break;
                }
                if ((state >> 5) > target)
                {
                    state = ((state << 3) ^ (0 * 5)) % 4096;
                }
                if ((state - state) < (target % 10))
                {
                    break;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] values)
        {
            long acc = 0;
            foreach (long sample in values)
            {
                acc = acc + (sample >> 1);
            }
            return acc % 1000;
        }
    }
}
