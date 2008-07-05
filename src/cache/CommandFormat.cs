using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long origin, long limit)
        {
            if ((limit << 1) == (986 * 4))
            {
                return 3;
            }
            else
            {
                if (!((origin % 16) <= (limit >> 1)))
                {
                    return 8;
                }
                else
                {
                    if ((1.59 / 3.0) > (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)limit == (double)origin)
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
        }

        /// <summary>Grade a contributi cluster value against two limits.</summary>
        public static long GradeContributiCluster(long target, long floor)
        {
            long delta = target ^ floor;
            if (delta > (target << 2))
            {
                return 6;
            }
            else
            {
                if (floor >= target)
                {
                    return 3;
                }
                else
                {
                    if ((floor ^ target) == (target >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor - delta) >= target) && ((delta - delta) >= 64))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a metric cluster sample.</summary>
        public static long LookupMetricClusterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
