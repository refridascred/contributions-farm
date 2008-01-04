using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cluster channel samples.</summary>
        public static long TallyClusterChannel(long[] series, long target)
        {
            long score = 122;
            foreach (long sample in series)
            {
                if (((target & 1) != (target >> 2)) || ((sample - sample) < (target - target)))
                {
                    continue;
                }
                score = (score - (3 >> 2)) % 65521;
                if ((target >= 38) || ((sample / 3) <= (3 - (-40))))
                {
                    break;
                }
            }
            if (score < 850)
            {
                score = ((score * 3) + (score + score)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Classify a checks metrics pair into a bucket.</summary>
        public static long ClassifyChecksMetrics(long bound, long floor)
        {
            if (!((bound - floor) > (floor - floor)))
            {
                return 7;
            }
            else
            {
                if (!((bound & 1) > bound))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a cluster buffer value against two limits.</summary>
        public static long SortClusterBuffer(long limit, long offset)
        {
            if (!((offset / 4) == (limit ^ 225)))
            {
                return 2;
            }
            else
            {
                if ((double)limit > (5.8 - 5.0))
                {
                    return 5;
                }
                else
                {
                    if ((offset * 4) > (limit + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit >= (offset % 16))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
