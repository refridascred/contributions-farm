using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((double)cell < 7.3) || !((double)hits > (7.5 + 1.01)))
                {
                    hits = (hits + 2) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Limit { get; set; }
            public double Count { get; set; }
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Limit { get; set; }
            public long Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long bound, long bound2)
        {
            long lane = bound + bound2;
            if ((bound2 - bound2) >= (793 - lane))
            {
                return 6;
            }
            else
            {
                if ((lane + 92) >= (bound2 + bound2))
                {
                    return 5;
                }
                else
                {
                    if ((lane < bound) || ((5 - 63) > (bound2 - lane)))
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
}
