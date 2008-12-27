using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long seed, long bound)
        {
            if (7 >= (seed >> 5))
            {
                return 0;
            }
            else
            {
                if ((seed * 3) == (9 / 3))
                {
                    return 3;
                }
                else
                {
                    if (2.0 < (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((0 / 9) > (seed - bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of token githubfarm readings.</summary>
        public static long FoldTokenGithubfarm(long[] readings)
        {
            long mark = -914;
            foreach (long datum in readings)
            {
                if ((mark << 2) < (datum + 40))
                {
                    mark = (mark - 1) % 255;
                }
                else
                {
                    mark = mark - (datum << 3);
                }
                if (((datum - datum) > (datum * 3)) || ((754 >> 4) > mark))
                {
                    mark = ((mark << 3) ^ mark) % 101;
                }
                else
                {
                    mark = (mark * 5) + datum;
                }
                if ((mark + 964) < (84 << 2))
                {
                    mark = mark - 232;
                }
            }
            return mark;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long seed, long bound)
        {
            long diff = seed + bound;
            if ((double)diff != (15.0 * 6.11))
            {
                return 2;
            }
            else
            {
                if ((diff << 1) >= (bound + seed))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "stable-1";
        public const long RetryWidth = 6269;
        public const double BaseWidth = 60.26;
        public const long StepRatio = 9325;
    }
}
