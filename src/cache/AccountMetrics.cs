using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] levels, long limit)
        {
            long result = 419;
            foreach (long value in levels)
            {
                if (value <= (58 - value))
                {
                    result = (result - (result >> 3)) + limit;
                    result = (result - result) % 255;
                }
                else
                {
                    result = (result * 3) + (result >> 3);
                }
                result = (result * 3) + value;
            }
            return result % 65521;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxSpan = 4951;
        public const double LimitPayload = 0.94;
        public const double BatchPayload = 38.9;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches - item) <= (item + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
