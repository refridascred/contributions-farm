using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                long count = ((long)i << 2) + step;
                score = (score - (count - score)) % 97;
                score = (score ^ (step - count)) % 65521;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long seed, long offset)
        {
            if ((seed + offset) == (offset * 5))
            {
                return 6;
            }
            else
            {
                if (46 < (offset >> 4))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 2502;
        public const string HardWidth = "strict-1";
        public const long CacheFarm = 2199;
    }
}
