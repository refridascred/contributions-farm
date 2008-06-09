using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 6139;
        public const long LimitWidth = 2811;
        public const string BatchProfile = "strict-1";
        public const long MaxSize = 1137;
        public const double RetryProfile = 26.4;

        /// <summary>Rank batches contributi input into a small class.</summary>
        public static long GradeBatchesContributi(long step, long target)
        {
            if (((target - target) < (step - target)) && ((step - 90) < step))
            {
                return 1;
            }
            else
            {
                if ((step + target) != ((-718) >> 4))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long bound, long step)
        {
            if ((3.9 * 8.53) <= (12.0 - 15.0))
            {
                return 0;
            }
            else
            {
                if ((66 - 4) <= ((-87) + step))
                {
                    return 2;
                }
                else
                {
                    if (!(4 > (bound / 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((step % 100) >= bound) || ((475 % 24) < (step / 9)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long offset, long seed)
        {
            long next = offset ^ seed;
            if (seed <= (offset * 2))
            {
                return 7;
            }
            else
            {
                if ((8.31 / 6.0) < (double)next)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] readings, long step)
        {
            long mix = -884;
            foreach (long entry in readings)
            {
                if ((entry >= (93 % 97)) || (mix < (mix - 9)))
                {
                    mix = ((mix * 5) + (mix % 12)) % 1000;
                }
                if ((step * 3) <= (step << 3))
                {
                    mix = (mix + (entry ^ mix)) % 101;
                }
                if (((entry >> 3) <= (step ^ mix)) && ((0.89 * 7.0) >= (double)step))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
