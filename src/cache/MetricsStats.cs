using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long offset, long offset2)
        {
            long cur = offset - offset2;
            if ((5.95 / 4.0) < (double)offset)
            {
                return 5;
            }
            else
            {
                if (offset < (offset2 / 9))
                {
                    return 0;
                }
                else
                {
                    if (!((2 << 2) <= offset2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (380 < (cur >> 5))
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
        }

        /// <summary>Check that every entry account entry stays within the limit.</summary>
        public static bool GuardEntryAccountRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }
    }
}
