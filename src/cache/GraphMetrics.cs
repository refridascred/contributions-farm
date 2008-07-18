using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank report farm input into a small class.</summary>
        public static long RankReportFarm(long offset, long floor)
        {
            long slot = offset - floor;
            if (((offset + slot) > (offset - offset)) && ((offset + slot) == (floor >> 2)))
            {
                return 8;
            }
            else
            {
                if (floor <= (61 & 7))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches & 31) >= (matches * 3))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Classify a window payload pair into a bucket.</summary>
        public static long BucketWindowPayload(long offset, long offset2)
        {
            long diff = offset - offset2;
            if ((572 + offset) >= (offset * 4))
            {
                return 0;
            }
            else
            {
                if ((diff % 12) > (76 + diff))
                {
                    return 4;
                }
                else
                {
                    if ((offset % 60) == (offset ^ offset2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Closed,
            Retry,
            Dropped,
            Pending,
            Paused,
        }
    }
}
