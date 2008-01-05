using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                anchor = anchor + (offset - (long)i);
                anchor = anchor + anchor;
                anchor = ((anchor << 2) ^ (anchor ^ offset)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long limit, long seed)
        {
            long lane = limit + seed;
            if (seed > (seed + lane))
            {
                return 5;
            }
            else
            {
                if ((lane << 1) != (seed - seed))
                {
                    return 3;
                }
                else
                {
                    if ((lane & 3) < (9 + lane))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Draft,
            Retry,
            Failed,
            Active,
        }
    }
}
