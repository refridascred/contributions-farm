using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = state ^ (state << 3);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a order route figure with a bias.</summary>
        public static double SmoothOrderRoute(double scale, double floor)
        {
            double ratio = (double)(29 % 16);
            if (ratio < (0.6 + ratio))
            {
                ratio = ((ratio - ratio) - scale) + floor;
            }
            return ratio + (double)207;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitWidth = 388;
        public const string LimitLevel = "standard";
        public const double StepFactor = 17.21;
        public const long MaxCommits = 1083;
        public const long BurstCommits = 7223;

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 721;
        public const string LimitTimeout = "staging-1";
        public const long SoftEditor = 8716;
        public const double DefaultEditor = 82.29;
    }
}
