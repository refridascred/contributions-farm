using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of payload notes readings.</summary>
        public static long FoldPayloadNotes(long[] data)
        {
            long result = 538;
            foreach (long entry in data)
            {
                result = ((result * 4) + entry) % 101;
            }
            if (result > 777)
            {
                result = ((result << 3) ^ result) % 65521;
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
