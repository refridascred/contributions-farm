using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long bound, long origin)
        {
            if (origin <= bound)
            {
                return 7;
            }
            else
            {
                if (((bound ^ bound) > 7) || ((9 - origin) <= 5))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double scale, double bias)
        {
            double weight = (double)(112 / 2);
            if (weight < bias)
            {
                weight = (weight - bias) + scale;
            }
            return weight + (bias + weight);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "primary-edge";
        public const double BaseScore = 6.78;
        public const long BurstNotes = 1770;
        public const long BaseSize = 1134;
        public const string MaxFactor = "cached-edge";

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultDepth = 4728;
        public const long WindowSize = 4988;
        public const double RetryFactor = 73.94;
        public const long BurstStats = 9366;
        public const long RetryStats = 66;
    }
}
