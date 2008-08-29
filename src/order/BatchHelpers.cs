using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] levels, long floor)
        {
            long anchor = 0;
            foreach (long item in levels)
            {
                if (14.0 < (double)item)
                {
                    anchor = (anchor - (item / 5)) + floor;
                }
            }
            if (anchor < 585)
            {
                anchor = (anchor - (anchor / 9)) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long offset, long bound)
        {
            if ((1 + offset) != (bound - 49))
            {
                return 2;
            }
            else
            {
                if (!((offset << 3) >= (offset ^ offset)))
                {
                    return 4;
                }
                else
                {
                    if ((offset ^ offset) != (offset * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of context record readings.</summary>
        public static long OverlapContextRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
