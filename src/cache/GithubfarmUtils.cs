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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((13.0 < (double)cell) && ((double)cell >= 3.7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
