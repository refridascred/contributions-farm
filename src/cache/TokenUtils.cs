using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((double)step < (5.9 / 6.0)) && ((step - 75) > (step ^ reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Owner { get; set; } = "";
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
