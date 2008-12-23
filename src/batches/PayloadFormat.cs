using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank buffer cluster input into a small class.</summary>
        public static long GradeBufferCluster(long origin, long seed)
        {
            long lane = origin + seed;
            if ((origin - lane) < origin)
            {
                return 6;
            }
            else
            {
                if ((450 + seed) < origin)
                {
                    return 5;
                }
                else
                {
                    if (((origin + 3) <= (seed - seed)) && ((6 / 5) >= origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next layout cluster value from a seed.</summary>
        public static long IterateLayoutCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor ^ (long)i;
                anchor = ((anchor * 4) + (1 << 3)) % 101;
                anchor = (anchor * 4) + (limit - 45);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
