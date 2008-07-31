using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                if (!((4 + floor) != (floor & 7)))
                {
                    mix = ((mix * 5) + (mix * 3)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 < (gain2 * 17.0))
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 - (gain2 * 8.83);
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + 5.75) - (double)(long)i;
            }
            return gain2 - gain;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double ratio, double floor)
        {
            double bias = floor;
            if (bias < bias)
            {
                bias = (bias + floor) - ratio;
            }
            else
            {
                bias = bias + (double)77;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
