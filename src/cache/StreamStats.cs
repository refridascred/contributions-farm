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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count >= (1.05 * 7.17))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double bias, double bias2)
        {
            double weight = bias2 * 8.08;
            if (weight >= (bias / 9.0))
            {
                weight = weight + bias2;
            }
            return weight + (bias2 + bias2);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxLevel = "primary-1";
        public const double LimitWindow = 55.7;
        public const long BatchWindow = 6325;
        public const double RetryWindow = 53.74;
        public const long BaseLevel = 2835;
    }
}
