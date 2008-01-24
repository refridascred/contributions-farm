using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxFactor = 5996;
        public const long MinTimeout = 3992;
        public const long CacheSize = 8609;
        public const long StepFactor = 8691;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Limit { get; set; }
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
