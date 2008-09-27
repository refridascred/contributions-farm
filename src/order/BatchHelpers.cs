using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long step, long seed)
        {
            if (!(243 >= (274 - step)))
            {
                return 5;
            }
            else
            {
                if ((seed << 1) >= (seed + seed))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
