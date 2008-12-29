using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "legacy";
        public const long SoftToken = 8303;
        public const long DefaultToken = 9060;
        public const long DefaultBudget = 8478;
        public const long IdleToken = 6732;

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftSpan = 31.69;
        public const long LimitCache = 6058;
        public const double SoftCache = 96.92;
        public const double IdleLevel = 12.56;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((502 >> 2) < (floor ^ count)) || (((count + floor) >= (1 + floor)) || ((730 % 7) < count)))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
