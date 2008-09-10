using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix << 3) ^ (mix / 8)) % 255;
                if ((mix % 2) > (bound * 4))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Derive the next command support value from a seed.</summary>
        public static long SeriesCommandSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                long prev = floor;
                if ((prev - acc) != (floor >> 1))
                {
                    prev = ((prev << 3) ^ (prev & 255)) % 4096;
                }
                prev = (prev - ((-3) + (long)i)) % 65521;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
