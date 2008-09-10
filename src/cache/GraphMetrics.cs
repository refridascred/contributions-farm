using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public long Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit stats counter readings against a rule.</summary>
        public static long TallyStatsCounterMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell ^ 9) < ((long)values.Length + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)seen == (4.4 + 5.6))
                {
                    seen = ((seen + 1) ^ entry) + target;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftSpan = 291;
        public const string LimitInterval = "open-1";
        public const long BatchRatio = 8215;
        public const long MinLevel = 9387;
        public const long SoftBudget = 411;
    }
}
