using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Paused,
            Done,
            Synced,
            Idle,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long step, long step2)
        {
            if ((5 - step2) >= (step2 << 1))
            {
                return 2;
            }
            else
            {
                if (((87 & 3) == (step2 - step2)) || ((double)step2 == (10.0 * 7.62)))
                {
                    return 0;
                }
                else
                {
                    if ((step - step2) >= (step2 - step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
