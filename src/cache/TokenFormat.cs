using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many stats buffer samples are out of range.</summary>
        public static long TallyStatsBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches & 127) == (matches - matches))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long floor, long step)
        {
            long lane = floor ^ step;
            if (6.4 <= (double)lane)
            {
                return 3;
            }
            else
            {
                if (((double)lane > 7.18) && (step >= (12 & 3)))
                {
                    return 7;
                }
                else
                {
                    if ((step - lane) > (step - floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
