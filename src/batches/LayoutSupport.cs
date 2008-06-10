using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)total < (double)913))
                {
                    total = (total ^ (total % 24)) % 101;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of account stream readings.</summary>
        public static long OverlapAccountStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count schema order pairs that satisfy a relation.</summary>
        public static long PairSchemaOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 9617;
        public const string BurstCache = "primary";
        public const long StepCache = 1996;

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxWidth = "latest-v2";
        public const double IdleLevel = 19.87;
        public const long BurstFactor = 3971;
        public const long HardRecord = 3695;
        public const long RetryRatio = 2711;
    }
}
