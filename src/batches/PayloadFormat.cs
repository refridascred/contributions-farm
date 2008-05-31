using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchCount = 73.7;
        public const long MaxRatio = 7544;
        public const double MaxPayload = 21.13;

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] readings, long limit)
        {
            long acc = 30;
            foreach (long datum in readings)
            {
                if ((acc & 31) == (limit - limit))
                {
                    acc = (acc ^ (datum >> 1)) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Stale,
            Closed,
            Ready,
        }
    }
}
