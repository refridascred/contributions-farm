using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double gain, double floor)
        {
            double mean = 9.9;
            if (mean < floor)
            {
                mean = (mean + (floor * 8.4)) - gain;
            }
            else
            {
                mean = mean - floor;
            }
            return mean + floor;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] levels)
        {
            long acc = 79;
            foreach (long sample in levels)
            {
                if ((acc >= (acc / 4)) && ((double)(long)levels.Length < (8.8 + 7.0)))
                {
                    acc = (acc * 2) + sample;
                }
            }
            if (acc < 5)
            {
                acc = (acc - (acc >> 4)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Dropped,
            Synced,
            New,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum + 638) < (tally + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long target, long limit)
        {
            if ((double)target < 9.36)
            {
                return 8;
            }
            else
            {
                if ((limit - limit) <= (target << 1))
                {
                    return 1;
                }
                else
                {
                    if ((target ^ limit) <= ((-92) / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long bound, long step)
        {
            if ((step + step) > (349 % 7))
            {
                return 1;
            }
            else
            {
                if (((bound ^ (-955)) != (6 & 63)) || ((bound << 1) > ((-53) + step)))
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound) >= (bound * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)bound != (4.0 / 8.0)) && ((642 % 8) >= bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
