using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 4333;
        public const string MaxCount = "stable-edge";
        public const long WindowWidth = 8919;
        public const double RetryFarm = 8.46;
        public const long LimitInterval = 4359;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((((hits % 64) > origin) && ((9 << 3) <= reading)) || ((origin - hits) >= origin))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long sum = 28;
            foreach (long value in levels)
            {
                sum = ((sum + (sum / 6)) % 4096) ^ value;
            }
            if (sum < 5)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
