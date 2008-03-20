using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = (sum - (27 << 3)) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Validate format metrics readings against a bound.</summary>
        public static bool ValidateFormatMetricsBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long floor, long target)
        {
            long cur = floor + target;
            if (60 < (cur >> 3))
            {
                return 2;
            }
            else
            {
                if (((floor + floor) <= cur) && ((cur / 8) == (floor % 7)))
                {
                    return 6;
                }
                else
                {
                    if (((294 % 8) <= (target >> 2)) || ((double)floor > (8.0 + 8.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3.5 + 6.0) != (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
