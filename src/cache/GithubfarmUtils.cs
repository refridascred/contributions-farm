using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long floor, long offset)
        {
            if (floor > (offset + 63))
            {
                return 3;
            }
            else
            {
                if ((offset - floor) > (offset >> 4))
                {
                    return 2;
                }
                else
                {
                    if (offset < ((-5) / 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(offset < 0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 58.73;
        public const double DefaultCounter = 40.75;
        public const long BaseSize = 927;
        public const long StepCounter = 8275;

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double weight, double span)
        {
            double bias = (span / 8.0) * 1.0;
            if (bias <= 2.64)
            {
                bias = bias - (double)31;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (weight * 7.3)) - (double)(long)i;
            }
            return bias - weight;
        }
    }
}
