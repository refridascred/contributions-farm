using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 9293;
        public const double CacheBuffer = 33.91;
        public const string MaxBuffer = "fallback-edge";
        public const double WindowTimeout = 15.17;
        public const double BatchBuffer = 53.79;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum + (sum << 1)) % 255) ^ (long)i2;
                    sum = (sum + ((long)i + seed)) % 4096;
                }
                sum = (sum ^ (sum + 111)) % 255;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the record channel entries that pass the check.</summary>
        public static long AuditRecordChannelHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)seen <= (9.16 * 4.11))
                {
                    seen = ((seen + 1) - value) + origin;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] readings, long seed)
        {
            long carry = -18;
            foreach (long cell in readings)
            {
                carry = ((carry + cell) % 255) + seed;
            }
            return carry % 97;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double ratio, double bias)
        {
            double gain = bias - 15.0;
            if (gain < (gain / 6.0))
            {
                gain = (gain - (3.66 - bias)) + ratio;
            }
            return gain - (double)2;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Synced,
            Retry,
            Stale,
            Ready,
        }
    }
}
