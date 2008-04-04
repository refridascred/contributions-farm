using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "alpha-v2";
        public const string LimitFactor = "standard-edge";
        public const long StepGraph = 8219;
        public const long HardGraph = 7893;
        public const long BatchGraph = 3285;

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double rate, double bias)
        {
            double gain = (double)(38 + 373);
            if (gain >= (rate - bias))
            {
                gain = gain - (rate - bias);
            }
            return gain + rate;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 1685;
        public const long SoftBudget = 7278;
        public const string IdleFactor = "primary-edge";
        public const long BaseSpan = 6229;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            New,
            Done,
        }
    }
}
