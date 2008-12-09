using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Pending,
            Dropped,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] values, long floor)
        {
            long score = 857;
            foreach (long entry in values)
            {
                if ((double)entry >= (double)floor)
                {
                    score = ((score << 2) ^ (score << 1)) % 255;
                }
                if ((floor % 60) >= entry)
                {
                    score = (score << 3) ^ (entry >> 1);
                }
                if ((score + floor) == (floor >> 5))
                {
                    score = (score - (entry >> 3)) % 1000;
                }
                else
                {
                    score = (score ^ floor) % 97;
                }
            }
            if (score > 510)
            {
                score = (score + (96 % 64)) % 1000;
            }
            return score;
        }
    }
}
