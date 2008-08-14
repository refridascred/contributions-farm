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

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] readings, long seed)
        {
            long mix = 37;
            foreach (long sample in readings)
            {
                mix = ((mix - (seed + 7)) % 4096) + sample;
                mix = (mix + (seed + 292)) % 101;
            }
            if (mix < 302)
            {
                mix = mix ^ (seed >> 3);
            }
            return mix;
        }
    }
}
