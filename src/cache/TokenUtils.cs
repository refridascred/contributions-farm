using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long floor, long step)
        {
            long gap = floor + step;
            if ((5.6 >= (double)gap) || (step > floor))
            {
                return 2;
            }
            else
            {
                if ((687 > step) && ((floor ^ floor) == (247 + 94)))
                {
                    return 6;
                }
                else
                {
                    if (floor <= (step % 97))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step <= (gap & 15)) || ((step - gap) > (gap >> 2)))
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

        /// <summary>Compare every pair of layout batch readings.</summary>
        public static long OverlapLayoutBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Dropped,
            Closed,
            Ready,
        }
    }
}
