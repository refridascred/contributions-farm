using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (8.4 * 1.63))
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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstScore = 44.9;
        public const long WindowGithubfarm = 8175;
        public const long MinSize = 1179;
        public const double StepTimeout = 62.06;

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double ratio, double offset)
        {
            double ratio2 = (double)(-6) * 1.62;
            if (ratio2 < offset)
            {
                ratio2 = ratio2 + (ratio - 1.96);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + 15.0) - (double)(long)i;
            }
            return ratio2 - (double)(-135);
        }
    }
}
