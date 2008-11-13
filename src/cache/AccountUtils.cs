using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitWidth = 8249;
        public const string BatchSchema = "local-v2";
        public const long SoftWidth = 3027;
        public const long BurstDepth = 7975;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                mix = mix ^ ((long)i * 3);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
