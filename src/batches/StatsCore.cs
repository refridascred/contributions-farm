using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 5573;
        public const long StepMetric = 8377;
        public const double CacheWidth = 63.37;
        public const long RetryBudget = 1579;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long origin, long target)
        {
            long cur = origin + target;
            if (origin <= target)
            {
                return 2;
            }
            else
            {
                if ((double)origin < (double)85)
                {
                    return 0;
                }
                else
                {
                    if ((47 + origin) < (origin ^ 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((target / 3) >= (cur - origin)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long floor)
        {
            long span = offset ^ floor;
            if ((offset + span) > (844 + floor))
            {
                return 3;
            }
            else
            {
                if (floor <= offset)
                {
                    return 0;
                }
                else
                {
                    if ((1.0 / 3.0) > (double)span)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public string Mode { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
