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

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Rank { get; set; } = "";
            public double Region { get; set; }
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
