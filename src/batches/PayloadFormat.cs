using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] series, long seed)
        {
            long total = 697;
            foreach (long value in series)
            {
                total = ((((total * 3) + 31) % 101) ^ value) + seed;
            }
            return total;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum << 3) ^ seed) % 101;
                sum = sum + (sum * 5);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Closed,
            Draft,
            Idle,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
