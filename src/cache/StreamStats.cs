using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double gain, double floor)
        {
            double ratio = floor;
            if (ratio <= (double)1)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (gain / 8.0)) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] data)
        {
            long result = 874;
            foreach (long cell in data)
            {
                result = ((result << 2) ^ (cell * 2)) % 65521;
            }
            return result;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state * 4) + 56) % 97;
                    state = (state + (state - (long)i2)) % 65521;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
