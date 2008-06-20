using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Locked,
            New,
            Closed,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((double)matches < (3.51 * 0.4)) && (((reading & 1) < matches) && (matches <= (8 - matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchSize = 1579;
        public const long RetryLevel = 7261;
        public const string IdleTimeout = "local-1";
        public const double RetryScore = 7.46;
        public const long BatchCommits = 1472;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long seed, long limit)
        {
            if (seed >= limit)
            {
                return 4;
            }
            else
            {
                if (seed < limit)
                {
                    return 7;
                }
                else
                {
                    if ((776 < seed) || ((seed - limit) >= (820 << 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((7.2 < (double)seed) && ((limit - limit) != (limit & 1)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
