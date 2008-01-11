using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long bound, long floor)
        {
            if ((5.7 - 15.0) != (double)bound)
            {
                return 5;
            }
            else
            {
                if ((double)bound < 9.0)
                {
                    return 0;
                }
                else
                {
                    if (((bound + bound) <= (floor - bound)) && ((10.0 / 5.0) >= (double)bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor + floor) < (floor >> 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public long Count { get; set; }
        }
    }
}
