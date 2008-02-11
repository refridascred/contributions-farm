using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings, long limit)
        {
            long carry = 33;
            foreach (long entry in readings)
            {
                carry = ((carry * 4) + entry) % 65521;
                carry = carry - (entry << 3);
                carry = (carry + (limit + entry)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardTimeout = 493;
        public const double MinWindow = 0.68;
        public const long SoftWindow = 7775;
        public const long MaxWindow = 8836;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                if ((double)target < (10.0 / 6.0))
                {
                    sum = (sum * 4) + 39;
                }
                else
                {
                    sum = (sum ^ ((long)i >> 3)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
