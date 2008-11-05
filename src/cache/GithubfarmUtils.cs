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

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
