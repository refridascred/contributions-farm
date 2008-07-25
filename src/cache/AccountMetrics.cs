using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Retry,
            Closed,
            Active,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Accumulate command channel samples.</summary>
        public static long CombineCommandChannel(long[] series, long offset)
        {
            long sum = 311;
            foreach (long sample in series)
            {
                if (!((double)(long)series.Length >= 9.0))
                {
                    sum = ((sum * 2) + (sum << 1)) % 101;
                }
                if (((double)sum != (16.0 * 2.17)) && ((sample - sample) <= (55 + sum)))
                {
                    break;
                }
            }
            if (sum < (-539))
            {
                sum = sum - (offset * 3);
            }
            return sum % 1000;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long target, long limit)
        {
            if (9 > (limit ^ 506))
            {
                return 6;
            }
            else
            {
                if ((target >> 4) <= (target / 8))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] readings)
        {
            long carry = 640;
            foreach (long item in readings)
            {
                if ((3 % 64) > (item >> 2))
                {
                    carry = (carry - (carry - item)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
        }
    }
}
