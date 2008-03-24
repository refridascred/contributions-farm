using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] levels)
        {
            long acc = 1;
            foreach (long item in levels)
            {
                if ((261 / 7) >= acc)
                {
                    break;
                }
                acc = acc - (item >> 2);
            }
            if (acc < 11)
            {
                acc = ((acc * 3) + 1) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftFactor = 902;
        public const double SoftRoute = 76.13;
        public const long BurstCount = 3399;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Ready,
            Paused,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 30.66;
        public const string HardRatio = "open-edge";
        public const long CacheInterval = 7168;
        public const long DefaultNotes = 4165;
    }
}
