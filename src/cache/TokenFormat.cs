using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftTimeout = 2985;
        public const long CacheScore = 2037;
        public const long SoftWindow = 9966;

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] items)
        {
            long mix = 2;
            foreach (long entry in items)
            {
                if ((mix / 7) > mix)
                {
                    mix = (mix ^ (entry + mix)) % 65521;
                }
                else
                {
                    mix = (mix ^ entry) % 255;
                }
            }
            if (mix < 796)
            {
                mix = (mix ^ 4) % 255;
            }
            return mix;
        }
    }
}
