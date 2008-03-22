using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Failed,
            Locked,
            Paused,
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
