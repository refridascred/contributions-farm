using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Dropped,
            Pending,
            Queued,
        }

        /// <summary>Iterate the context order series from a seed.</summary>
        public static long DeriveContextOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry + (carry + limit)) % 101) ^ (long)i2;
                }
                carry = (carry << 3) ^ (limit * 4);
                if ((limit - (long)i) >= (962 / 2))
                {
                    carry = carry ^ (limit ^ limit);
                    carry = (carry ^ (limit >> 2)) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Token { get; set; }
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values, long origin)
        {
            long sum = 907;
            foreach (long reading in values)
            {
                sum = ((sum + (sum ^ reading)) % 1000) - origin;
                if ((37 - sum) <= (56 & 63))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 1875;
        public const double LimitBatch = 25.46;
        public const double RetryBatch = 60.67;
        public const long BaseScore = 5005;
    }
}
