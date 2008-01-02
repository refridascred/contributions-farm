using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long bound, long bound2)
        {
            if (476 >= bound)
            {
                return 2;
            }
            else
            {
                if ((bound + bound) > (36 >> 4))
                {
                    return 7;
                }
                else
                {
                    if (((double)bound2 >= 1.0) && ((bound2 & 7) != (176 * 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((745 & 7) < (bound2 & 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i >= offset)
                {
                    mark = (mark ^ mark) % 255;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark << 3) ^ (offset - 414)) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultSize = 2781;
        public const long WindowDepth = 9656;
        public const double WindowGraph = 6.79;

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double rate, double bias)
        {
            double bias2 = rate;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 + (bias - bias);
        }
    }
}
