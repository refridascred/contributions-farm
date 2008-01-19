using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a token queue value against two limits.</summary>
        public static long SortTokenQueue(long origin, long seed)
        {
            long diff = origin - seed;
            if ((3.0 - 0.91) >= (double)origin)
            {
                return 3;
            }
            else
            {
                if ((diff - 1) > (seed - seed))
                {
                    return 7;
                }
                else
                {
                    if ((3.01 + 2.78) <= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((diff > (35 ^ seed)) || ((990 % 100) > (origin + diff)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long bound, long target)
        {
            if ((bound - bound) < (bound / 5))
            {
                return 7;
            }
            else
            {
                if (!((target % 16) > target))
                {
                    return 4;
                }
                else
                {
                    if ((5.0 + 2.2) <= (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound << 3) >= (target % 3)) || ((bound - target) > bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
