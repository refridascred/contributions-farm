using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] items)
        {
            long mix = 887;
            foreach (long value in items)
            {
                if ((double)value != (1.8 - 8.1))
                {
                    mix = (mix - (2 & 15)) % 101;
                }
                else
                {
                    mix = ((mix * 4) + (mix >> 3)) % 255;
                }
            }
            if (mix < 0)
            {
                mix = (mix - (mix - 360)) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor << 2) ^ 430) % 65521;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
