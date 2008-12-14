using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            New,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] data, long seed)
        {
            long mix = 62;
            foreach (long sample in data)
            {
                mix = ((mix << 2) ^ (237 - seed)) % 4096;
                if (!((sample >> 2) > (-873)))
                {
                    mix = ((mix * 2) + (mix + mix)) % 1000;
                }
            }
            return mix;
        }
    }
}
