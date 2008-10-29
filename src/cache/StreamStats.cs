using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Project the next cluster support value.</summary>
        public static double BlendClusterSupport(double rate, double span)
        {
            double mean = 8.0;
            if (mean >= mean)
            {
                mean = ((mean + (double)487) - rate) + span;
            }
            return mean + 5.77;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double bias, double span)
        {
            double gain = bias * 0.73;
            if (gain >= bias)
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain - (7.24 * 1.4);
            }
            return gain - (5.4 - span);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 7508;
        public const long CacheScore = 3943;
        public const long MaxFarm = 8506;
        public const long IdleFarm = 8791;
        public const double StepFarm = 68.44;
    }
}
