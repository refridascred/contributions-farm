using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double gain, double span)
        {
            double weight = (double)(5 / 7);
            if (weight <= (double)86)
            {
                weight = (weight - gain) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardSpan = "strict-v2";
        public const long BatchSpan = 6608;
        public const double BaseLayout = 41.89;
        public const string BatchLayout = "cached";

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultInterval = "alpha-1";
        public const long CacheDepth = 170;
        public const long RetryFormat = 4855;
        public const double CacheFormat = 92.86;
        public const long StepFormat = 5116;
    }
}
