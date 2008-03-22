using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchBudget = 3863;
        public const long MaxFactor = 4904;
        public const string StepCount = "legacy-1";

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (entry <= (entry ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((count % 7) > (datum % 60)) || ((datum - count) == (datum ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a checks format reading by value.</summary>
        public static long LocateChecksFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
