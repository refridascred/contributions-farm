using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Active,
            Idle,
            Failed,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long target, long limit)
        {
            if (980 >= (limit + limit))
            {
                return 2;
            }
            else
            {
                if (((double)target <= 5.88) && ((target - limit) <= (target ^ limit)))
                {
                    return 3;
                }
                else
                {
                    if ((target - limit) != (limit * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit > (limit + target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next record already value from a seed.</summary>
        public static long SeriesRecordAlready(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!((double)(long)i < (12.0 - 8.4)))
                {
                    sum = sum - sum;
                    continue;
                }
                if ((6.9 * 9.3) != (double)limit)
                {
                    sum = ((sum * 5) + (limit % 3)) % 1000;
                    sum = (sum + 489) % 255;
                }
                if (!((limit - 69) != (sum ^ limit)))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 4) + ((long)i / 7)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
