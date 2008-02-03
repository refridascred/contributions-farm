using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double floor)
        {
            double gain = ratio;
            if (gain > (gain * 2.4))
            {
                gain = gain + (floor / 4.0);
            }
            else
            {
                gain = gain + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (floor - gain)) - (double)(long)i;
            }
            return gain - ratio;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 5377;
        public const long LimitDepth = 3606;
        public const double BatchRatio = 36.18;
        public const long DefaultCommits = 2160;
        public const long BaseCommits = 935;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Closed,
            New,
        }
    }
}
