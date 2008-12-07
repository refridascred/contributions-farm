using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long floor, long offset)
        {
            long next = floor + offset;
            if (((9 << 3) < offset) && (7.7 < (double)next))
            {
                return 6;
            }
            else
            {
                if (((offset + 71) <= (offset + 61)) && ((floor % 8) >= 516))
                {
                    return 3;
                }
                else
                {
                    if ((3.9 + 5.7) <= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)floor > 2.78) && ((double)next == (double)65))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
