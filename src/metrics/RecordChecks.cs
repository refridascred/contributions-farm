using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long seed, long offset)
        {
            if ((seed ^ offset) < (seed + seed))
            {
                return 0;
            }
            else
            {
                if (((offset % 16) > offset) && (525 > (offset << 1)))
                {
                    return 1;
                }
                else
                {
                    if (offset < 8)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset <= (double)2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
