using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (seed < ((long)levels.Length ^ 8))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Grade a profile counter value against two limits.</summary>
        public static long BucketProfileCounter(long seed, long limit)
        {
            if ((limit + seed) >= limit)
            {
                return 8;
            }
            else
            {
                if ((seed & 127) == (limit + seed))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed > (1.17 - 6.3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (2.8 <= (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public bool Score { get; set; }
        }
    }
}
