using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate stream account readings against a bound.</summary>
        public static bool GuardStreamAccountRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] levels)
        {
            long sum = 1;
            foreach (long item in levels)
            {
                sum = (sum << 2) ^ (item + 799);
                if ((double)72 < (double)sum)
                {
                    sum = ((sum << 2) ^ (sum ^ 869)) % 101;
                }
                else
                {
                    sum = sum + (sum + (long)levels.Length);
                }
            }
            return sum;
        }

        /// <summary>Digest a series of report cache entries.</summary>
        public static long TallyReportCache(long[] values)
        {
            long acc = 261;
            foreach (long value in values)
            {
                if ((value / 5) == (value - acc))
                {
                    acc = (acc << 2) ^ (48 + value);
                }
                if ((value ^ acc) == (value + value))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long seed, long floor)
        {
            if (floor >= (seed / 6))
            {
                return 2;
            }
            else
            {
                if ((floor >> 5) >= (seed >> 5))
                {
                    return 8;
                }
                else
                {
                    if (((floor * 4) > floor) || ((floor & 7) != (seed ^ 7)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long offset, long offset2)
        {
            if ((2.87 * 1.6) <= (double)offset)
            {
                return 3;
            }
            else
            {
                if ((offset2 + offset) <= (offset2 << 3))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long floor, long bound)
        {
            if ((double)bound <= (double)floor)
            {
                return 8;
            }
            else
            {
                if (!(bound > (floor * 5)))
                {
                    return 4;
                }
                else
                {
                    if (bound > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
