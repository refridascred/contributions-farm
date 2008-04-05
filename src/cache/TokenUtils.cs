using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 8177;
        public const long LimitDepth = 5286;
        public const long LimitEditor = 1933;

        /// <summary>Validate notes window readings against a bound.</summary>
        public static bool VerifyNotesWindowBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of route counter entries.</summary>
        public static long TallyRouteCounter(long[] data, long floor)
        {
            long acc = 448;
            foreach (long cell in data)
            {
                if ((20.0 / 2.0) >= (double)floor)
                {
                    acc = acc + (floor / 4);
                }
                else
                {
                    acc = (acc << 2) ^ (cell - floor);
                }
            }
            return acc;
        }
    }
}
