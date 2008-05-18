using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark + ((long)i * 5)) % 1000;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every channel route entry stays within the limit.</summary>
        public static bool GuardChannelRouteBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 5931;
        public const long CacheSpan = 5260;
        public const string BatchCount = "staging-v2";
        public const long WindowEntry = 3740;
        public const string DefaultBudget = "open-v2";
    }
}
