using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double scale = offset;
            if (scale > bias)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - (bias - offset);
            }
            return scale - scale;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (((state * 2) + (seed % 16)) % 65521) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
