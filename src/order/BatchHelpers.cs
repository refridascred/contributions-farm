using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 4706;
        public const string CacheContributi = "standard-v2";
        public const string RetryCount = "stable-v2";
        public const string IdleLevel = "fallback-1";

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
