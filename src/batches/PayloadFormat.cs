using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 2908;
        public const double MinStream = 26.44;
        public const string CacheStream = "staging-edge";
        public const string BurstStream = "fallback";

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 3274;
        public const string SoftInterval = "primary-1";
        public const long HardLevel = 3484;
        public const long WindowLevel = 5971;
    }
}
