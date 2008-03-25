using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a metric checks value against two limits.</summary>
        public static long ClassifyMetricChecks(long seed, long limit)
        {
            if (((6.3 / 3.0) != (double)seed) && ((seed + seed) != (limit - seed)))
            {
                return 2;
            }
            else
            {
                if ((42 & 1) > seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed ^ seed) >= 9)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed & 3) >= (6 - seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] data, long offset)
        {
            long mark = 272;
            foreach (long value in data)
            {
                mark = mark ^ (mark << 1);
                if ((value * 2) <= (offset & 15))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample << 3) < (step - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
