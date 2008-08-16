using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = (state - (85 - (long)i)) % 1000;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate notes counter readings against a bound.</summary>
        public static bool CheckNotesCounterBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 7079;
        public const string SoftWidth = "stable-v2";
        public const long BaseStats = 477;
        public const long RetryTimeout = 2632;
    }
}
