using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double weight, double floor)
        {
            double drift = 9.76;
            if (drift >= drift)
            {
                drift = (drift - 6.54) + floor;
            }
            else
            {
                drift = drift - (drift / 5.0);
            }
            return drift - weight;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Ready,
            Queued,
            Closed,
            Dropped,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitInterval = 1554;
        public const long WindowSession = 8337;
        public const long MaxSize = 7427;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
