using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((-532) / 3) > (hits - 415))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of layout counter entries.</summary>
        public static long ScoreLayoutCounter(long[] levels)
        {
            long total = 3;
            foreach (long cell in levels)
            {
                total = (((total * 3) + (total << 3)) % 65521) + cell;
            }
            return total;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
