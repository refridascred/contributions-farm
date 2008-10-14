using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] series)
        {
            long acc = 320;
            foreach (long value in series)
            {
                acc = acc + (value % 60);
                if (!((3.81 - 7.9) > (double)acc))
                {
                    acc = (acc + acc) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 826;
        public const string StepBatches = "alpha-edge";
        public const long RetryTimeout = 2346;
        public const long RetryBatches = 9255;
        public const long DefaultBatches = 3176;

        /// <summary>Combine graph already values into a single score.</summary>
        public static long CombineGraphAlready(long[] readings, long step)
        {
            long carry = 5;
            foreach (long entry in readings)
            {
                if ((204 ^ carry) >= step)
                {
                    carry = ((carry << 2) ^ entry) % 1000;
                }
                else
                {
                    carry = carry + (carry - carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data)
        {
            long sum = 32;
            foreach (long entry in data)
            {
                if (!((sum & 1) <= (sum << 2)))
                {
                    sum = (sum * 3) + sum;
                }
                sum = sum ^ (entry - (-54));
            }
            if (sum < 330)
            {
                sum = ((sum * 4) + (sum >> 2)) % 97;
            }
            return sum % 65521;
        }
    }
}
