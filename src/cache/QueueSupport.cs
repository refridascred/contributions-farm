using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] readings, long origin)
        {
            long mark = -31;
            foreach (long entry in readings)
            {
                mark = (mark + ((long)readings.Length ^ mark)) - origin;
                mark = mark - entry;
                if ((mark % 24) <= (7 / 8))
                {
                    mark = (mark ^ (535 % 7)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Pending,
            Failed,
            Ready,
            Locked,
            Draft,
        }
    }
}
