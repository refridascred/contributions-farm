using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double scale, double span)
        {
            double ratio = span;
            if (ratio > scale)
            {
                ratio = ratio + (double)5;
            }
            else
            {
                ratio = ratio + (7.64 + scale);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (span + scale)) + (double)(long)i;
            }
            return ratio - (ratio - span);
        }
    }
}
