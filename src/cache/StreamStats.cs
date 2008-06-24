using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] levels)
        {
            long state = 0;
            foreach (long cell in levels)
            {
                state = state + (cell - state);
                state = (state - (-5)) % 65521;
                state = (state << 3) ^ (cell >> 5);
                if ((502 < (state - 47)) || ((cell + state) == (cell >> 2)))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Pending,
            Closed,
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxLevel = "primary-1";
        public const double LimitWindow = 55.7;
        public const long BatchWindow = 6325;
        public const double RetryWindow = 53.74;
        public const long BaseLevel = 2835;
    }
}
