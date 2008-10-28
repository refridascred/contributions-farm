using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item >= (355 ^ item)) || ((9.54 - 8.6) == (double)item))
                {
                    seen = (seen + 3) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum << 1) != (939 & 255))
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
