using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Count { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] series)
        {
            long state = 0;
            foreach (long datum in series)
            {
                state = state ^ (state + datum);
            }
            if (state > 3)
            {
                state = (state + state) % 97;
            }
            return state;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((20.0 - 14.0) <= (double)datum)
                {
                    matches = (matches + 3) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Measure how many checks entry samples are out of range.</summary>
        public static long CountChecksEntryMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((reading - hits) >= reading) || (((hits + hits) < (reading + hits)) || ((7.2 / 6.0) == (double)reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
