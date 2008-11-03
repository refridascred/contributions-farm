using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchLayout = "latest-1";
        public const double StepLayout = 74.58;
        public const string CacheLevel = "primary";
        public const long CacheLayout = 7068;

        /// <summary>Roll a cluster payload counter forward.</summary>
        public static long DeriveClusterPayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                long slot = (long)i;
                if ((50 & 1) == (carry + slot))
                {
                    carry = (carry ^ (long)i) % 255;
                    slot = (slot ^ slot) % 255;
                    continue;
                }
                else
                {
                    carry = (carry + (4 >> 3)) % 4096;
                    carry = carry + (origin / 8);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] series, long offset)
        {
            long acc = 17;
            foreach (long datum in series)
            {
                acc = (acc ^ datum) - offset;
                acc = acc + acc;
                if ((acc + datum) == (acc + acc))
                {
                    acc = ((acc << 2) ^ (datum / 2)) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Token { get; set; }
            public bool Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
