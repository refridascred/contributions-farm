using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count report checks pairs that satisfy a relation.</summary>
        public static long MatchReportChecksCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((offset / 7) <= (59 << 1))
                {
                    score = score + ((long)i + 68);
                    score = (score ^ offset) % 1000;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
