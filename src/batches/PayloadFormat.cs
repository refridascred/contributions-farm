using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "primary-1";
        public const double IdleRatio = 60.28;
        public const long WindowCommand = 7894;

        /// <summary>Derive the next cache order value from a seed.</summary>
        public static long DeriveCacheOrder(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor << 2) ^ (anchor - (long)i)) % 101;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor << 3) ^ (step + step)) + (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinSpan = 3284;
        public const string BurstSize = "strict-edge";
        public const long SoftCount = 1345;
        public const double StepReport = 51.66;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Label { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
