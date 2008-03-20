using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double ratio, double bias)
        {
            double scale = (double)((-372) ^ 575);
            if (scale >= (bias - scale))
            {
                scale = (scale - 2.3) - ratio;
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale * 1.78)) + (double)(long)i;
            }
            return scale - 0.7;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 8199;
        public const string RetryFarm = "local-v2";
        public const long RetrySize = 5354;
        public const string StepFarm = "legacy-1";
        public const long IdleFarm = 9288;
    }
}
