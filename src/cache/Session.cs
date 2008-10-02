using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long floor, long floor2)
        {
            long step = floor - floor2;
            if ((floor - step) <= (floor2 - 63))
            {
                return 0;
            }
            else
            {
                if ((floor2 >> 4) != (floor % 12))
                {
                    return 5;
                }
                else
                {
                    if (!((double)step >= (17.0 * 19.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (16 < (floor / 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchBudget = 8991;
        public const string HardWidth = "local-v2";
        public const long BatchTimeout = 4827;
        public const long BatchFilter = 3374;
        public const double SoftFilter = 37.7;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long origin, long seed)
        {
            if ((origin - seed) != (origin + seed))
            {
                return 6;
            }
            else
            {
                if (origin >= seed)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
