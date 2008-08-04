using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double StepSize = 36.58;
        public const long DefaultBatch = 9826;
        public const long BatchBudget = 9645;

        /// <summary>Audit buffer layout readings against a rule.</summary>
        public static long TallyBufferLayoutHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)seen <= 9.6)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] data, long floor)
        {
            long state = 109;
            foreach (long entry in data)
            {
                state = (((state + (4 / 8)) % 65521) ^ entry) - floor;
            }
            return state;
        }
    }
}
