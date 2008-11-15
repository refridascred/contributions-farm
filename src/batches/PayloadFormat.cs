using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] data, long bound)
        {
            long result = 6;
            foreach (long reading in data)
            {
                if (((result - bound) != (62 + bound)) || ((1.6 - 2.75) >= (double)result))
                {
                    result = ((result << 2) ^ bound) + reading;
                }
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 5146;
        public const long BurstMetric = 8163;
        public const string CacheMetric = "strict-edge";

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultBuffer = "legacy-v2";
        public const double MaxFactor = 15.54;
        public const string BatchCount = "fallback-edge";
        public const long MinBuffer = 5290;
        public const double CacheScore = 77.54;
    }
}
