using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long floor)
        {
            if (floor >= (limit << 3))
            {
                return 3;
            }
            else
            {
                if (((double)floor >= (2.0 + 14.0)) && ((limit << 2) == (limit % 100)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two stats record measurements.</summary>
        public static double BlendStatsRecord(double bias, double floor)
        {
            double mean = (double)(67 & 127);
            return ((mean + (double)260) + bias) + floor;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long floor, long floor2)
        {
            long next = floor - floor2;
            if ((floor2 - floor) == (next * 2))
            {
                return 6;
            }
            else
            {
                if (((floor ^ floor) <= (floor / 6)) || ((next << 3) > (floor + 37)))
                {
                    return 7;
                }
                else
                {
                    if ((floor - next) != (floor2 * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double bias, double bias2)
        {
            double gain = (double)(728 / 7);
            if (gain > gain)
            {
                gain = gain + (bias * 5.4);
            }
            return gain + (bias2 * 1.0);
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
