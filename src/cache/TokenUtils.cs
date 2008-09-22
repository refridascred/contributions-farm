using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((step + 829) == (sample + hits))
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

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of order filter readings.</summary>
        public static long FoldOrderFilter(long[] series, long step)
        {
            long score = 9;
            foreach (long reading in series)
            {
                score = ((score << 3) ^ (step * 3)) - reading;
                score = score - (step * 4);
            }
            return score;
        }
    }
}
