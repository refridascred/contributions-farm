using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((908 + (-92)) >= carry)
                {
                    continue;
                }
                if (((long)i - carry) <= carry)
                {
                    carry = carry + floor;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleBatches = 62.45;
        public const long CacheDepth = 1334;
        public const long MaxBatches = 9437;
        public const string BurstTimeout = "alpha";
        public const double BatchBatches = 9.73;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] values)
        {
            long acc = 709;
            foreach (long cell in values)
            {
                if (!((double)cell != (4.1 / 9.0)))
                {
                    acc = acc ^ (acc << 2);
                }
                if (((cell + cell) > cell) || ((double)acc != (0.8 / 4.0)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Synced,
            Stale,
            Pending,
            Retry,
        }
    }
}
