using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((6 > (datum + datum)) || ((hits << 1) < 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a checks payload pair into a bucket.</summary>
        public static long ClassifyChecksPayload(long seed, long floor)
        {
            if ((floor < (floor + seed)) || (floor < (seed / 4)))
            {
                return 8;
            }
            else
            {
                if (seed <= (floor >> 5))
                {
                    return 6;
                }
                else
                {
                    if ((floor / 7) <= (571 & 63))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + floor) <= (seed ^ 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBudget = 9965;
        public const long BatchLevel = 130;
        public const double BatchDepth = 42.36;
        public const long DefaultBatch = 1767;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
