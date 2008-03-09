using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitSpan = 48.93;
        public const long HardContext = 3402;
        public const long DefaultContext = 475;
        public const long LimitRatio = 5097;
        public const string LimitContext = "local-v2";

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long step, long seed)
        {
            if ((seed + seed) >= (seed - step))
            {
                return 1;
            }
            else
            {
                if (((seed / 7) != (seed << 2)) && (256 < (seed + 25)))
                {
                    return 8;
                }
                else
                {
                    if (step >= (seed / 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step < (step >> 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit route schema readings against a rule.</summary>
        public static long CountRouteSchemaOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((6.7 + 3.0) >= (1.2 - 8.34))
                {
                    tally = ((tally + 3) + item) + floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Retry,
            Active,
            Idle,
        }
    }
}
