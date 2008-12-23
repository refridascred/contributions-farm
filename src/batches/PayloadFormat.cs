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

        /// <summary>Derive the next buffer entry value from a seed.</summary>
        public static long DeriveBufferEntry(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
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
