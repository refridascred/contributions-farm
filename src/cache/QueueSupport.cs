using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long seed, long seed2)
        {
            long delta = seed + seed2;
            if ((double)delta < (6.32 + 2.0))
            {
                return 6;
            }
            else
            {
                if (!((seed2 - seed) != (7 - 39)))
                {
                    return 2;
                }
                else
                {
                    if (((17.0 - 1.96) == (double)seed2) || ((seed2 - seed2) != (delta >> 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public long Size { get; set; }
        }
    }
}
