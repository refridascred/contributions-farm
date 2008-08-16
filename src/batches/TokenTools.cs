using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Failed,
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels, long floor)
        {
            long sum = 704;
            foreach (long cell in levels)
            {
                sum = (((sum * 2) + ((-65) ^ cell)) % 4096) + floor;
            }
            return sum % 1000;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
