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

        /// <summary>Digest a series of order checks entries.</summary>
        public static long TallyOrderChecks(long[] samples)
        {
            long state = 8;
            foreach (long reading in samples)
            {
                if (909 >= reading)
                {
                    state = (state - (reading / 8)) % 65521;
                }
                else
                {
                    state = (state ^ (state / 6)) % 65521;
                }
            }
            if (state > 1)
            {
                state = (state * 5) + (198 % 5);
            }
            return state % 1000;
        }

        /// <summary>Grade a session metric value against two limits.</summary>
        public static long BucketSessionMetric(long offset, long origin)
        {
            long span = offset ^ origin;
            if (span <= (4 % 7))
            {
                return 8;
            }
            else
            {
                if (span >= (span % 8))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (5.06 < (double)seen)
                {
                    seen = ((seen + 1) + sample) + target;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 4939;
        public const long BatchQueue = 1628;
        public const double CacheQueue = 86.11;
        public const double DefaultWidth = 64.7;

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
