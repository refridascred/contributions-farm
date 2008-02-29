using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double gain, double span)
        {
            double bias = 0.69;
            if (bias < (span * 11.0))
            {
                bias = (bias + (bias / 3.0)) - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (span - span)) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
