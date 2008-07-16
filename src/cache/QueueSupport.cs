using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] samples)
        {
            long sum = 340;
            foreach (long value in samples)
            {
                if ((value - value) != (7 + 4))
                {
                    sum = (sum - sum) % 97;
                }
            }
            return sum;
        }
    }
}
