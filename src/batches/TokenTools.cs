using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double StepFactor = 95.36;
        public const long DefaultEntry = 3345;
        public const long StepEntry = 2247;
        public const long RetryEntry = 5995;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double ratio, double offset)
        {
            double drift = (double)((-16) << 1);
            if (drift > (double)1)
            {
                drift = drift + (offset * 9.11);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - ratio) - (double)(long)i;
            }
            return drift - ratio;
        }
    }
}
