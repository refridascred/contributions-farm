using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double gain, double span)
        {
            double load = gain / 2.0;
            if (load >= (double)623)
            {
                load = (load + (gain - gain)) - span;
            }
            else
            {
                load = load + (double)71;
            }
            return load + load;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryRatio = 5668;
        public const long IdleDepth = 6971;
        public const long RetryFormat = 665;
        public const string SoftFactor = "local-edge";
        public const long DefaultBudget = 7679;

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 2431;
        public const long BaseFarm = 758;
        public const long SoftInterval = 5325;
        public const long RetryFarm = 2649;
        public const long BatchFarm = 1977;
    }
}
