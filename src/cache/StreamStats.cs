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

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] readings, long step)
        {
            long anchor = 68;
            foreach (long item in readings)
            {
                anchor = (anchor ^ (step << 3)) + item;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Done,
            Stale,
            Idle,
            Active,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxLevel = "primary-1";
        public const double LimitWindow = 55.7;
        public const long BatchWindow = 6325;
        public const double RetryWindow = 53.74;
        public const long BaseLevel = 2835;
    }
}
