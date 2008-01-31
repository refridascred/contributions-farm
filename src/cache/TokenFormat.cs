using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] levels, long origin)
        {
            long total = 59;
            foreach (long item in levels)
            {
                if ((item <= (total + item)) || ((double)total > (2.0 + 0.2)))
                {
                    total = (total ^ (origin & 255)) % 255;
                }
                else
                {
                    total = (total + (28 + item)) % 4096;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
        }
    }
}
