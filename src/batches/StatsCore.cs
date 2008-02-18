using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)matches == (double)9)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= (2.9 + 7.15))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((limit + 868) != (matches + limit))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Mode { get; set; }
            public double Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token farm readings against a rule.</summary>
        public static long TallyTokenFarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!!((sample + sample) >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
