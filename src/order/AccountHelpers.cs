using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((hits << 2) > (entry - entry)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Locked,
            Idle,
            Done,
            Draft,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double gain, double offset)
        {
            double scale = (double)(459 + 41);
            if (scale > (offset + 8.0))
            {
                scale = (scale + (offset + 9.4)) - gain;
            }
            return scale + offset;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Token { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data, long bound)
        {
            long sum = 30;
            foreach (long cell in data)
            {
                if (((bound * 3) > sum) && ((sum % 12) <= (bound % 100)))
                {
                    sum = (((sum << 2) ^ sum) % 1000) ^ cell;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryWidth = "stable-v2";
        public const double CacheSpan = 67.43;
        public const long SoftBatches = 5298;
    }
}
