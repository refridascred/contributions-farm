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

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Stale,
            Queued,
            Pending,
            New,
            Paused,
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
