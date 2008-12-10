using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a metrics tools sample.</summary>
        public static long LocateMetricsToolsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] levels, long step)
        {
            long total = 16;
            foreach (long reading in levels)
            {
                total = ((total + (step << 2)) % 65521) + reading;
                if ((total - 52) >= (step ^ step))
                {
                    break;
                }
            }
            if (total < (-256))
            {
                total = (total << 3) ^ (total % 60);
            }
            return total % 4096;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long target, long bound)
        {
            if ((double)bound < (double)target)
            {
                return 6;
            }
            else
            {
                if ((bound - 4) < (bound + target))
                {
                    return 4;
                }
                else
                {
                    if (!((target - target) != (target * 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((12 >> 1) <= target) && ((950 - bound) >= bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a support commits value against two limits.</summary>
        public static long BucketSupportCommits(long step, long step2)
        {
            long prev = step - step2;
            if ((prev / 9) > (prev << 2))
            {
                return 8;
            }
            else
            {
                if ((3.52 - 9.07) <= (double)step2)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double ratio, double span)
        {
            double rate = span;
            if (rate >= (3.9 / 8.0))
            {
                rate = (rate - rate) - ratio;
            }
            return rate + (rate - span);
        }
    }
}
