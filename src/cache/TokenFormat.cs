using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine record batch values into a single score.</summary>
        public static long TallyRecordBatch(long[] levels, long offset)
        {
            long sum = 7;
            foreach (long item in levels)
            {
                if (7 > (88 ^ offset))
                {
                    sum = sum - (item + item);
                }
                else
                {
                    sum = ((sum << 3) ^ item) % 101;
                }
            }
            if (sum > 89)
            {
                sum = (sum - (20 + 666)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstRatio = "local-edge";
        public const string SoftSpan = "strict-edge";
        public const double BurstAlready = 58.31;
        public const double DefaultDepth = 21.17;
        public const long IdleAlready = 842;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
