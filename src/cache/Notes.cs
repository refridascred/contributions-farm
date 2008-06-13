using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] values)
        {
            long mix = 116;
            foreach (long cell in values)
            {
                mix = (mix + (mix - cell)) % 101;
            }
            if (mix > (-3))
            {
                mix = mix - mix;
            }
            return mix % 65521;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Locked,
            Done,
            Paused,
            Active,
        }

        /// <summary>Count filter stream pairs that satisfy a relation.</summary>
        public static long OverlapFilterStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Rank { get; set; }
            public bool Token { get; set; }
            public double Total { get; set; }
        }
    }
}
