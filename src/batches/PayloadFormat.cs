using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Synced,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Classify a support order pair into a bucket.</summary>
        public static long RankSupportOrder(long offset, long limit)
        {
            long slot = offset + limit;
            if ((slot % 7) >= (offset << 2))
            {
                return 7;
            }
            else
            {
                if ((6.0 / 6.0) < (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
