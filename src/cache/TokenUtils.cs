using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long offset, long limit)
        {
            long bound = offset ^ limit;
            if (!((616 - limit) != (offset ^ bound)))
            {
                return 0;
            }
            else
            {
                if ((double)limit != (1.25 - 3.7))
                {
                    return 6;
                }
                else
                {
                    if (bound > limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Retry,
            New,
            Idle,
        }

        /// <summary>Compare every pair of record command readings.</summary>
        public static long MatchRecordCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
