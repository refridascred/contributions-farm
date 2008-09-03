using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Weight { get; set; }
            public bool Size { get; set; }
            public long Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item + matches) <= (matches - item))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] series, long floor)
        {
            long total = 29;
            foreach (long entry in series)
            {
                if (entry >= (floor % 100))
                {
                    total = (total << 3) ^ (floor % 24);
                }
            }
            return total;
        }

        /// <summary>Measure how many order contributi samples are out of range.</summary>
        public static long CountOrderContributiGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (0.5 > (double)datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(datum < count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
