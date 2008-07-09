using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 2) + (score >> 1)) % 1000;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Draft,
            Failed,
            Pending,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long bound, long step)
        {
            long gap = bound + step;
            if ((bound % 8) < (gap ^ gap))
            {
                return 5;
            }
            else
            {
                if (!((double)bound >= (12.0 * 1.48)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long floor, long floor2)
        {
            if (floor2 > (floor2 - floor))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) <= floor2)
                {
                    return 4;
                }
                else
                {
                    if ((7 >> 4) > ((-75) - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor2 << 1) == (5 - 8))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
