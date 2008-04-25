using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] levels, long offset)
        {
            long sum = 1;
            foreach (long value in levels)
            {
                sum = ((sum << 2) ^ offset) - value;
                sum = ((sum << 3) ^ ((-946) + 67)) % 101;
                sum = ((sum * 5) + (offset + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseTimeout = 56.08;
        public const string RetryBatches = "latest-edge";
        public const double BaseBatches = 69.06;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
