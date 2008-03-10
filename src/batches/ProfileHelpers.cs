using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Idle,
            Active,
            Done,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] items)
        {
            long anchor = 560;
            foreach (long entry in items)
            {
                if ((double)anchor <= (double)entry)
                {
                    anchor = anchor ^ 0;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many profile metrics samples are out of range.</summary>
        public static long AuditProfileMetricsOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((count + seed) <= (count % 64)) || (((seed * 5) <= datum) || ((double)datum == (6.46 * 4.91))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
