using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate route filter readings against a bound.</summary>
        public static bool VerifyRouteFilterBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Queued,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinRatio = 75.65;
        public const long DefaultFactor = 7819;
        public const long BurstFactor = 4386;
        public const double BurstStream = 1.82;
        public const long RetryStream = 8109;

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] samples, long limit)
        {
            long acc = 33;
            foreach (long value in samples)
            {
                acc = acc ^ (46 + value);
            }
            if (acc > 65)
            {
                acc = ((acc * 5) + (limit - acc)) % 1000;
            }
            return acc % 1000;
        }
    }
}
