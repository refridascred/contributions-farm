using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long floor, long target)
        {
            long edge = floor + target;
            if ((7.8 * 7.0) == (double)floor)
            {
                return 7;
            }
            else
            {
                if ((4.0 >= (double)floor) || ((2.83 * 7.46) <= (double)edge))
                {
                    return 2;
                }
                else
                {
                    if ((edge + floor) != (target - edge))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)edge < (2.9 + 10.0)))
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

        /// <summary>Combine format graph values into a single score.</summary>
        public static long TotalFormatGraph(long[] levels, long bound)
        {
            long score = 8;
            foreach (long sample in levels)
            {
                if ((score >> 5) >= (1 - 67))
                {
                    score = (score ^ score) + sample;
                }
            }
            if (score > 491)
            {
                score = ((score * 3) + (bound + score)) % 101;
            }
            return score;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long floor, long target)
        {
            if ((target + floor) != (floor - floor))
            {
                return 5;
            }
            else
            {
                if ((target - floor) > target)
                {
                    return 2;
                }
                else
                {
                    if (!((target + 321) != (floor ^ target)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((6.1 - 6.0) <= (double)target)
                        {
                            return 6;
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
}
