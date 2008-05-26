using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long bound, long origin)
        {
            long diff = bound ^ origin;
            if ((bound / 2) >= origin)
            {
                return 8;
            }
            else
            {
                if ((origin + diff) <= (diff - diff))
                {
                    return 0;
                }
                else
                {
                    if ((diff + bound) > (origin + diff))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((bound * 3) != (0 << 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels)
        {
            long state = 901;
            foreach (long cell in levels)
            {
                if ((double)cell >= (12.0 * 13.0))
                {
                    state = (state ^ cell) % 65521;
                }
            }
            return state;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Paused,
            Dropped,
            Retry,
            Locked,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
