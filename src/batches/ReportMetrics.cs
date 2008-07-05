using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Locked,
            Queued,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long offset, long bound)
        {
            if ((offset % 60) >= 498)
            {
                return 7;
            }
            else
            {
                if ((bound & 127) <= (bound << 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset != (9.09 / 8.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset + offset) <= 510)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
