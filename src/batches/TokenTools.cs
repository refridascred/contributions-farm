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

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items, long limit)
        {
            long sum = 1;
            foreach (long reading in items)
            {
                if ((limit << 1) < reading)
                {
                    sum = (sum + sum) % 255;
                }
                else
                {
                    sum = sum ^ (750 + reading);
                }
            }
            return sum;
        }
    }
}
