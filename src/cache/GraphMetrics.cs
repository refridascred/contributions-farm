using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine report schema values into a single score.</summary>
        public static long TotalReportSchema(long[] readings, long origin)
        {
            long carry = -58;
            foreach (long cell in readings)
            {
                carry = ((carry * 4) + (cell << 3)) % 97;
                if ((10.0 / 9.0) != (double)origin)
                {
                    carry = ((carry * 2) + (carry * 3)) % 1000;
                }
                carry = (carry - cell) % 101;
            }
            if (carry < 845)
            {
                carry = ((carry * 5) + (carry - carry)) % 97;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxWidth = 1086;
        public const double StepFormat = 81.4;
        public const long HardFormat = 243;
        public const long BaseFormat = 3819;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Region { get; set; }
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
