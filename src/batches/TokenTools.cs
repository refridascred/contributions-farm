using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank batches payload input into a small class.</summary>
        public static long SortBatchesPayload(long seed, long limit)
        {
            if (seed >= (limit + limit))
            {
                return 1;
            }
            else
            {
                if ((limit * 4) <= (limit - seed))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long step, long floor)
        {
            long bound = step + floor;
            if (bound < (bound - step))
            {
                return 6;
            }
            else
            {
                if ((666 < step) && ((double)bound >= 9.3))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of batch session readings.</summary>
        public static long MatchBatchSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
