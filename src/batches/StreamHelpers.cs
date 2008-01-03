using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Stale,
            Idle,
            Pending,
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter checks readings against a rule.</summary>
        public static long TallyFilterChecksHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((hits < origin) && ((origin >> 3) != (hits + origin))) && ((double)hits != (double)origin))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinFactor = "alpha-edge";
        public const double BatchSpan = 22.75;
        public const long BatchGraph = 7965;
        public const long CacheGraph = 2944;
        public const long MinGraph = 6187;

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long limit, long target)
        {
            if ((double)limit < 7.35)
            {
                return 1;
            }
            else
            {
                if (!(limit < 1))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit >= (12.0 * 4.86))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
