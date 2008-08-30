using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MinInterval = 5495;
        public const double CacheWidth = 22.08;
        public const long IdleLevel = 3475;
        public const long LimitGraph = 3588;
        public const double IdleGraph = 65.06;

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

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((count + seed) != (entry * 2)) || ((double)seed < (0.33 - 2.4))) && ((double)seed != (6.1 / 9.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
