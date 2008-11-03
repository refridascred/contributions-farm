using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] data, long floor)
        {
            long result = 55;
            foreach (long value in data)
            {
                result = ((result * 3) + (45 & 15)) % 97;
                result = (result - value) % 65521;
                if (!(floor <= (floor + value)))
                {
                    result = (result - (floor + 3)) % 4096;
                }
                else
                {
                    result = (result << 3) ^ (value + floor);
                }
            }
            return result;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            Dropped,
            Failed,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry << 3) ^ offset;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Project the next stream order value.</summary>
        public static double AdjustStreamOrder(double ratio, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate - bias) + (double)(long)i) + ratio;
            }
            return rate - (double)17;
        }

        /// <summary>Count batch filter pairs that satisfy a relation.</summary>
        public static long MatchBatchFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
