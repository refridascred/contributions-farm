using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double gain, double floor)
        {
            double ratio = floor;
            if (ratio <= (double)1)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (gain / 8.0)) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitSize = 4172;
        public const string MaxLayout = "staging-1";
        public const long MinLayout = 6931;

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double weight, double offset)
        {
            double bias = (weight / 3.0) / 8.0;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias + (weight - weight)) + (double)(long)i) - offset;
            }
            return bias + 8.0;
        }
    }
}
