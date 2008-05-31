using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of contributi tools readings.</summary>
        public static long TotalContributiTools(long[] series, long step)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                acc = ((acc * 5) + (cell % 12)) % 65521;
                acc = acc + step;
            }
            if (acc > 19)
            {
                acc = ((acc << 3) ^ (step + acc)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Match up checks commits samples.</summary>
        public static long PairChecksCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Locked,
            Stale,
            Active,
        }
    }
}
