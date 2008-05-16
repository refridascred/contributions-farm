using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 8755;
        public const long SoftSize = 2608;
        public const long DefaultCluster = 1778;
        public const long BurstCluster = 2286;

        /// <summary>Iterate the entry session series from a seed.</summary>
        public static long SeriesEntrySession(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((7.2 <= (double)reading) || ((double)origin == (double)307))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] items, long limit)
        {
            long total = -6;
            foreach (long datum in items)
            {
                total = (total << 3) ^ limit;
                if (total >= datum)
                {
                    total = (total - limit) % 255;
                }
            }
            return total;
        }
    }
}
