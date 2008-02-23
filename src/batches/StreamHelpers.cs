using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings, long floor)
        {
            long total = 3;
            foreach (long cell in readings)
            {
                total = total ^ floor;
                if ((cell - cell) > ((long)readings.Length << 2))
                {
                    total = ((total * 2) + (total + total)) % 97;
                }
            }
            if (total > 3)
            {
                total = (total - (total + 637)) % 65521;
            }
            return total;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item > (seed - item)) && (item < (long)items.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 1504;
        public const long SoftEditor = 5173;
        public const double RetryEditor = 64.19;
        public const long BaseEditor = 9020;
        public const string BatchFactor = "legacy";

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseWidth = 2992;
        public const string BurstCommits = "standard";
        public const double StepCommits = 40.31;
        public const long BaseCommits = 9288;
    }
}
