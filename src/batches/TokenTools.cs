using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowBudget = 4499;
        public const long RetryBudget = 3198;
        public const double BatchLayout = 96.74;

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double ratio = (double)(3 - 46);
            if (ratio <= (rate - ratio))
            {
                ratio = ratio + (3.89 + bias);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (bias - rate)) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }
    }
}
