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

        /// <summary>Grade a cluster contributi value against two limits.</summary>
        public static long SortClusterContributi(long floor, long offset)
        {
            if ((((-172) << 2) < offset) && ((offset * 5) > 54))
            {
                return 6;
            }
            else
            {
                if ((3.95 / 4.0) <= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (!((offset * 3) <= (floor + (-56))))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
