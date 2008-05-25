using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            Failed,
            Done,
            Dropped,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double rate, double floor)
        {
            double drift = floor;
            if (drift >= (7.0 / 3.0))
            {
                drift = (drift + (double)568) - rate;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (floor + 4.82)) + (double)(long)i;
            }
            return drift - (drift * 6.77);
        }

        /// <summary>Match up stats report samples.</summary>
        public static long PairStatsReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
