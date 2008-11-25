using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                if (((total % 60) <= total) && (0.4 >= (double)total))
                {
                    total = ((total << 2) ^ (floor * 4)) % 65521;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = ((total ^ floor) % 65521) ^ (long)i2;
                    total = ((total * 2) + (floor & 15)) % 101;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Active,
            New,
            Locked,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (floor ^ floor)) % 97;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
