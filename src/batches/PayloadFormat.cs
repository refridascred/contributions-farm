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

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 4745;
        public const long MaxFactor = 3719;
        public const long BaseFactor = 6994;
        public const long WindowLevel = 2088;

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
