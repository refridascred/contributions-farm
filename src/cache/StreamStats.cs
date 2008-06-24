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

        /// <summary>Derive the next record channel value from a seed.</summary>
        public static long IterateRecordChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = result ^ (origin + result);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
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
