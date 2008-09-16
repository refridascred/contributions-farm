using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSpan = 4629;
        public const long MaxLevel = 4171;
        public const double HardSession = 51.14;
        public const double RetrySession = 86.25;
        public const long CacheSession = 8018;

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                if (699 <= (carry & 127))
                {
                    carry = (carry + carry) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
