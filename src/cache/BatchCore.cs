using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample >> 5) >= (sample + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long limit, long target)
        {
            if (limit < (560 << 3))
            {
                return 4;
            }
            else
            {
                if ((double)limit > 2.0)
                {
                    return 1;
                }
                else
                {
                    if ((limit + target) >= 7)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit stream already readings against a rule.</summary>
        public static long TallyStreamAlreadyHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((seen - floor) >= floor) || (((3.04 - 8.7) != (double)sample) || ((2.28 / 4.0) < (double)sample)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
