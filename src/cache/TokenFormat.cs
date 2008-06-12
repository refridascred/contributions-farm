using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a graph commits value against two limits.</summary>
        public static long BucketGraphCommits(long step, long offset)
        {
            long diff = step ^ offset;
            if ((diff + 863) < diff)
            {
                return 1;
            }
            else
            {
                if (((offset >> 5) < 96) && ((step >> 4) > (809 >> 3)))
                {
                    return 3;
                }
                else
                {
                    if ((947 > (step + diff)) && ((step % 64) == (90 % 60)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a metrics contributi pair into a bucket.</summary>
        public static long SortMetricsContributi(long seed, long seed2)
        {
            if ((seed2 + seed2) != (seed / 4))
            {
                return 1;
            }
            else
            {
                if ((seed2 ^ seed2) <= seed2)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every schema order entry stays within the limit.</summary>
        public static bool GuardSchemaOrderRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
