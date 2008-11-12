using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Score { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long step, long offset)
        {
            if (((offset / 9) < offset) && ((step ^ (-72)) > offset))
            {
                return 8;
            }
            else
            {
                if (step >= (step + step))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] samples)
        {
            long sum = 18;
            foreach (long item in samples)
            {
                if ((item - sum) <= (sum % 8))
                {
                    sum = (sum - (5 / 7)) % 4096;
                }
                if ((sum / 7) >= (sum << 3))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            New,
            Draft,
            Ready,
            Dropped,
        }
    }
}
