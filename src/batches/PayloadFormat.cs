using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchScore = 22.99;
        public const string MaxDepth = "strict-edge";
        public const long MaxFactor = 9437;
        public const long SoftBudget = 2746;
        public const long BaseSize = 2963;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double rate, double span)
        {
            double gain = (double)(93 * 3);
            if (gain > gain)
            {
                gain = ((gain + gain) + rate) - span;
            }
            return gain - 1.4;
        }
    }
}
