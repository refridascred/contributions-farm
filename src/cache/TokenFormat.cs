using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] data)
        {
            long mix = 1;
            foreach (long entry in data)
            {
                if (((double)mix <= (7.2 + 8.9)) && ((36 * 4) >= (entry & 15)))
                {
                    mix = mix + entry;
                }
            }
            if (mix < 266)
            {
                mix = (mix << 2) ^ 19;
            }
            return mix;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Score { get; set; }
            public double Count { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc - (long)i) % 65521;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (((acc * 2) + (7 / 4)) % 255) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
