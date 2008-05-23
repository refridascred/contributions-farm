using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long bound, long offset)
        {
            long offset2 = bound - offset;
            if ((bound * 3) <= bound)
            {
                return 4;
            }
            else
            {
                if (((offset - bound) >= offset2) || (bound >= 8))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset2 < (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Label { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Idle,
            Queued,
        }
    }
}
