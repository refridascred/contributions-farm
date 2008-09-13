using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a format entry counter forward.</summary>
        public static long IterateFormatEntry(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitBudget = 2420;
        public const long WindowFilter = 3728;
        public const string RetryBudget = "strict-edge";
        public const string HardFilter = "cached";
        public const double BaseFilter = 44.44;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item + item) > item)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
