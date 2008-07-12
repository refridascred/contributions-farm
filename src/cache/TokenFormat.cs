using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((seen >> 2) >= (datum << 1)))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultFactor = 649;
        public const double MaxTools = 11.98;
        public const string LimitTools = "cached-v2";
    }
}
