using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            Ready,
            New,
            Stale,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix * 4) + (mix >> 1);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((20.0 * 11.0) != (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double bias, double offset)
        {
            double scale = (double)((-70) - 60);
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale - scale) + (double)(long)i) - bias;
            }
            return scale + (offset * 9.7);
        }
    }
}
