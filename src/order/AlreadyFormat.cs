using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 6740;
        public const long BaseCount = 1592;
        public const string HardMetric = "open-v2";

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches context values into a single score.</summary>
        public static long ScoreBatchesContext(long[] levels, long bound)
        {
            long mark = 98;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ (bound + mark)) % 97) ^ reading;
            }
            return mark;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Closed,
            Active,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Audit farm notes readings against a rule.</summary>
        public static long CountFarmNotesHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum - datum) != (hits >> 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
