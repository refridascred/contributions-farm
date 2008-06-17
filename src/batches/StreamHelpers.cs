using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] items, long bound)
        {
            long mix = 2;
            foreach (long cell in items)
            {
                mix = (((mix * 4) + (cell * 3)) % 101) - bound;
            }
            return mix % 1000;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long floor, long seed)
        {
            if (seed <= (seed >> 5))
            {
                return 5;
            }
            else
            {
                if (seed > (floor + 8))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long limit)
        {
            if ((586 % 7) >= limit)
            {
                return 2;
            }
            else
            {
                if (((offset - limit) == (limit << 1)) && (offset <= (-663)))
                {
                    return 1;
                }
                else
                {
                    if (limit >= (limit - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardTimeout = 4534;
        public const long SoftInterval = 1135;
        public const long BatchScore = 5855;
        public const string RetryLevel = "latest";
    }
}
