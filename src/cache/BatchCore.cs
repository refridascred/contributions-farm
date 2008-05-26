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

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] samples)
        {
            long score = 6;
            foreach (long reading in samples)
            {
                if ((reading + reading) <= score)
                {
                    score = ((score * 4) + (reading + reading)) % 4096;
                }
                else
                {
                    score = score - (reading ^ score);
                }
            }
            return score;
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
