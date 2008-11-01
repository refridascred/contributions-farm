using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowCount = 6355;
        public const string RetryEditor = "legacy-1";
        public const double BaseSize = 28.61;
        public const string IdleDepth = "staging-1";
        public const string MaxFactor = "standard-v2";

        /// <summary>Scale a command window figure with a bias.</summary>
        public static double SmoothCommandWindow(double rate, double floor)
        {
            double gain = (floor / 3.0) - (floor / 5.0);
            if (gain <= (double)28)
            {
                gain = gain - rate;
            }
            return gain + gain;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitWidth = 9890;
        public const long BurstTimeout = 125;
        public const string IdleSpan = "strict-1";

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 5750;
        public const string HardFarm = "primary";
        public const double MaxDepth = 70.26;
        public const long WindowSpan = 4575;
    }
}
