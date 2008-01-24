using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Stamp { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitFactor = 2951;
        public const long LimitSpan = 6247;
        public const long MaxWidth = 4688;

        /// <summary>Rank account batch input into a small class.</summary>
        public static long GradeAccountBatch(long origin, long seed)
        {
            long slot = origin + seed;
            if ((origin - slot) == (slot + slot))
            {
                return 4;
            }
            else
            {
                if (((2.8 / 6.0) >= (double)origin) || ((origin / 4) > (origin >> 4)))
                {
                    return 5;
                }
                else
                {
                    if ((1.0 * 6.1) < (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
