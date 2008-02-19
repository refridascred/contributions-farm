using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 2200;
        public const double HardFactor = 84.0;
        public const long IdleDepth = 2558;
        public const long DefaultSize = 1754;

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] samples)
        {
            long mix = 6;
            foreach (long value in samples)
            {
                mix = ((mix << 2) ^ (value - mix)) % 1000;
                if (((value << 2) == (2 ^ (long)samples.Length)) || (905 < (value % 60)))
                {
                    mix = ((mix << 3) ^ value) % 255;
                }
            }
            if (mix < 260)
            {
                mix = (mix - (mix * 5)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
