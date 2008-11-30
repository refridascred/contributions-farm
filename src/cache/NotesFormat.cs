using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of stream command readings.</summary>
        public static long DigestStreamCommand(long[] samples)
        {
            long state = 950;
            foreach (long cell in samples)
            {
                state = ((state * 2) + (cell + cell)) % 65521;
                state = ((state * 2) + state) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultLevel = 10.92;
        public const double LimitFactor = 58.87;
        public const string DefaultDepth = "latest-v2";
    }
}
