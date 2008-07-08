using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long result = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result << 2) ^ (result * 2)) - (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long offset, long bound)
        {
            long step = offset ^ bound;
            if (bound < offset)
            {
                return 4;
            }
            else
            {
                if ((double)offset == (13.0 - 19.0))
                {
                    return 1;
                }
                else
                {
                    if ((step > (bound + 5)) || ((double)bound == (2.0 * 13.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long floor, long bound)
        {
            long next = floor - bound;
            if (floor >= (floor * 4))
            {
                return 6;
            }
            else
            {
                if ((9 + floor) == (bound & 255))
                {
                    return 2;
                }
                else
                {
                    if (((floor ^ next) < next) || ((next + next) != (next * 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((41 % 5) >= (bound + 53))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
