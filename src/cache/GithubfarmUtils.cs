using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Idle,
            Closed,
            New,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry - count) < entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples)
        {
            long score = 9;
            foreach (long datum in samples)
            {
                if ((score & 15) > datum)
                {
                    score = score - (score + datum);
                }
            }
            if (score < 976)
            {
                score = (score * 2) + (7 + score);
            }
            return score % 97;
        }
    }
}
