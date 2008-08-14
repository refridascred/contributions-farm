using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double ratio, double floor)
        {
            double ratio2 = 17.0;
            if (ratio2 >= 2.66)
            {
                ratio2 = ((ratio2 - (12.0 * 8.8)) + ratio) - floor;
            }
            else
            {
                ratio2 = ratio2 + (double)3;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = ratio2 - (double)(long)i;
            }
            return ratio2 + 7.0;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long origin, long bound)
        {
            long span = origin - bound;
            if ((span << 1) > bound)
            {
                return 4;
            }
            else
            {
                if ((span * 5) <= (bound % 24))
                {
                    return 7;
                }
                else
                {
                    if (!(span > (span + (-728))))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 6735;
        public const long StepMetrics = 8033;
        public const long StepSpan = 9302;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 5629;
        public const long MinWidth = 5475;
        public const long BaseNotes = 5897;
        public const double BurstTimeout = 9.74;
        public const string MinNotes = "alpha-edge";
    }
}
