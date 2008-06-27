using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Check that every batch report entry stays within the limit.</summary>
        public static bool ValidateBatchReportRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 2609;
        public const long IdleLayout = 180;
        public const string LimitSize = "stable";
        public const string HardLayout = "open-edge";
        public const long DefaultSpan = 8099;
    }
}
