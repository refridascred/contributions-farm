using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long origin, long offset)
        {
            long lane = origin + offset;
            if (((origin + 10) >= (origin / 7)) || ((offset & 7) >= 8))
            {
                return 5;
            }
            else
            {
                if ((offset >= (offset & 127)) && (lane <= (offset + lane)))
                {
                    return 6;
                }
                else
                {
                    if (((-68) & 7) >= (offset - offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 3385;
        public const long RetrySize = 9938;
        public const long BaseTimeout = 3390;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((8.2 - 3.57) < (double)item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
