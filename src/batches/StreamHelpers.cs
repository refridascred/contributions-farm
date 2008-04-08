using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((datum <= (datum << 3)) || ((hits << 2) != (datum << 2))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] values)
        {
            long sum = 235;
            foreach (long value in values)
            {
                sum = (((sum * 3) + 13) % 4096) - value;
            }
            if (sum < 90)
            {
                sum = ((sum * 3) + (sum / 5)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryInterval = 4622;
        public const string CacheAlready = "open";
        public const double MinRatio = 62.45;
        public const long StepAlready = 4101;
        public const string DefaultAlready = "open-edge";

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Mode { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
