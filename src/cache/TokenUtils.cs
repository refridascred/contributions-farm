using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long floor, long origin)
        {
            long slot = floor ^ origin;
            if (!((8.0 / 2.0) >= (double)slot))
            {
                return 2;
            }
            else
            {
                if ((floor - origin) >= (origin << 2))
                {
                    return 1;
                }
                else
                {
                    if (57 >= (slot & 63))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((slot + slot) >= floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            New,
            Locked,
            Pending,
            Closed,
        }
    }
}
