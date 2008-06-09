using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Synced,
            New,
            Locked,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)6 > (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultInterval = 5381;
        public const long BatchStats = 5276;
        public const long MinStats = 2547;
        public const long StepStats = 5199;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
