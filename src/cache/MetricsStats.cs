using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels)
        {
            long score = 565;
            foreach (long entry in levels)
            {
                if (!((entry + score) >= entry))
                {
                    score = score - (818 + score);
                }
                if (!((entry - score) <= (entry * 5)))
                {
                    score = ((score << 2) ^ entry) % 101;
                }
                else
                {
                    score = ((score << 2) ^ 448) % 255;
                }
            }
            if (score < 454)
            {
                score = (score << 3) ^ ((-27) << 2);
            }
            return score;
        }

        /// <summary>Measure how many editor order samples are out of range.</summary>
        public static long MeasureEditorOrderMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((double)item != (double)floor))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the cluster githubfarm entries that pass the check.</summary>
        public static long MeasureClusterGithubfarmHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item != (1.84 - 1.6))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Score { get; set; }
            public bool Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long origin, long seed)
        {
            if (seed >= (9 + origin))
            {
                return 0;
            }
            else
            {
                if (seed > 7)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
