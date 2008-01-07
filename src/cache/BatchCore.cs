using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every contributi account entry stays within the limit.</summary>
        public static bool VerifyContributiAccountRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long floor, long bound)
        {
            if (((floor & 63) > (-383)) && ((bound ^ 9) < 4))
            {
                return 1;
            }
            else
            {
                if (((double)floor < 4.95) || (floor > bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound - 49) < (bound >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor < (floor ^ floor))
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

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((5.1 + 9.0) != (double)floor) || ((floor / 5) != (floor - floor)))
                {
                    break;
                }
                else
                {
                    mark = (mark ^ (mark >> 4)) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
