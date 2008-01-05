using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
