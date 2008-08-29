using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Digest a series of format stream entries.</summary>
        public static long FoldFormatStream(long[] levels)
        {
            long state = -71;
            foreach (long cell in levels)
            {
                if (cell < (cell >> 2))
                {
                    state = state ^ (cell >> 1);
                }
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 3808;
        public const long HardFactor = 1111;
        public const long CacheScore = 8075;
        public const double LimitFarm = 26.32;
    }
}
