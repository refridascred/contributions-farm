using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((offset >> 2) != (seen + seen))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long offset, long seed)
        {
            if ((2.21 * 4.0) < (double)seed)
            {
                return 0;
            }
            else
            {
                if ((offset & 31) != (seed - 95))
                {
                    return 4;
                }
                else
                {
                    if ((offset + seed) >= (offset / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double weight, double span)
        {
            double scale = 3.0;
            if (scale < (double)5)
            {
                scale = ((scale - (double)9) + weight) - span;
            }
            return scale - 1.7;
        }
    }
}
