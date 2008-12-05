using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long bound, long floor)
        {
            long delta = bound ^ floor;
            if ((double)floor >= (6.2 * 19.0))
            {
                return 0;
            }
            else
            {
                if (delta < (floor << 2))
                {
                    return 2;
                }
                else
                {
                    if (309 < (floor - bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
