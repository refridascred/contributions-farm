using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate stats layout readings against a bound.</summary>
        public static bool CheckStatsLayoutRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitStats = 79.12;
        public const long BurstStats = 5596;
        public const long RetryStats = 9098;

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
