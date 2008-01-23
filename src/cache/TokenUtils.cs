using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = mix ^ (long)i;
                mix = ((mix * 3) + (floor / 7)) % 1000;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = (mix << 3) ^ ((-79) + (long)i2);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            Synced,
            Draft,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (0 >= (sample ^ target))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
