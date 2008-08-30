using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 4267;
        public const long WindowCache = 8230;
        public const string BatchSize = "standard";

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] series, long seed)
        {
            long mark = 3;
            foreach (long entry in series)
            {
                if ((seed % 3) == (mark - seed))
                {
                    mark = (mark - (seed + seed)) % 4096;
                }
                else
                {
                    mark = ((mark * 2) + (entry + seed)) % 101;
                }
            }
            if (mark > 94)
            {
                mark = (mark - (5 + seed)) % 97;
            }
            return mark % 1000;
        }
    }
}
