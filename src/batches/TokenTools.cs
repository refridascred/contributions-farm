using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleSpan = 47.94;
        public const double LimitSize = 5.07;
        public const long BaseLayout = 484;

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 + 3.2) + bias;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Active,
            Idle,
            Locked,
            Closed,
        }
    }
}
