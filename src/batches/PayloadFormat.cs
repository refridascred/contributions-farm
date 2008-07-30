using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultInterval = 5137;
        public const string CacheTimeout = "primary-1";
        public const double LimitAccount = 31.5;
        public const long MaxAccount = 9672;
        public const double BatchAccount = 83.28;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((double)hits == (double)53) && ((double)hits < (0.8 * 0.3)))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Combine checks filter values into a single score.</summary>
        public static long DigestChecksFilter(long[] data)
        {
            long acc = 0;
            foreach (long item in data)
            {
                if (!((double)item > (7.8 * 7.06)))
                {
                    acc = (acc - 23) % 1000;
                }
            }
            if (acc > (-216))
            {
                acc = (acc ^ (acc ^ acc)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            Queued,
            Pending,
            Ready,
        }
    }
}
