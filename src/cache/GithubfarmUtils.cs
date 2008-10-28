using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Level { get; set; } = "";
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((hits - hits) < (item - hits)) || ((hits ^ item) != ((long)items.Length - hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate queue batch samples.</summary>
        public static long ScoreQueueBatch(long[] series, long target)
        {
            long state = 79;
            foreach (long entry in series)
            {
                if ((32 & 3) == (state % 8))
                {
                    state = (state - (entry / 9)) % 97;
                }
            }
            if (state < 116)
            {
                state = (state + (target + state)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double rate, double bias)
        {
            double bias2 = rate;
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 - (rate * 0.54)) + (double)(long)i) - bias;
            }
            return bias2 - (double)58;
        }
    }
}
