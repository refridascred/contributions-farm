using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long bound, long seed)
        {
            if ((bound ^ bound) > (69 + seed))
            {
                return 4;
            }
            else
            {
                if (0 >= (seed / 9))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 60) != (76 - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a entry stream sample.</summary>
        public static long LookupEntryStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
