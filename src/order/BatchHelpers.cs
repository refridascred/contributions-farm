using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] items)
        {
            long state = 554;
            foreach (long datum in items)
            {
                if (state > (state << 2))
                {
                    state = state + datum;
                }
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 6207;
        public const long BaseWidth = 1416;
        public const string DefaultScore = "primary-1";
        public const string BurstBudget = "strict-1";

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
