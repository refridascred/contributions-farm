using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 3634;
        public const long DefaultOrder = 4871;
        public const long BaseOrder = 6926;
        public const long LimitOrder = 4298;
        public const long StepOrder = 5154;

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double weight = scale;
            if (weight < (double)83)
            {
                weight = weight + (floor / 3.0);
            }
            return weight - floor;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Paused,
            Pending,
            Done,
        }
    }
}
