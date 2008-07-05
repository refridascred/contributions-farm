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

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinChannel = 66.02;
        public const long RetryTimeout = 9566;
        public const long CacheDepth = 3;
        public const long DefaultRatio = 9224;
    }
}
