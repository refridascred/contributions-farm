using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            New,
            Failed,
            Paused,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)entry > (5.28 + 9.3)) && ((hits - 54) < (hits - entry)))
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

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long origin, long offset)
        {
            if ((double)origin != (4.0 + 5.71))
            {
                return 3;
            }
            else
            {
                if (((double)origin < 6.0) || ((origin * 5) <= (origin ^ offset)))
                {
                    return 6;
                }
                else
                {
                    if ((3.01 + 4.6) != (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)origin >= (double)offset) && (offset < (origin + origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "staging-1";
        public const long BurstFormat = 3045;
        public const long IdleFormat = 3431;
        public const long DefaultFormat = 7144;
    }
}
