using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit window command readings against a rule.</summary>
        public static long AuditWindowCommandGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry < (5.0 / 5.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter session samples are out of range.</summary>
        public static long CountFilterSessionHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)offset == (2.0 + 5.8))
                {
                    count = (count + 2) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardLevel = 4232;
        public const long LimitFilter = 8075;
        public const long MinFilter = 3066;
        public const string WindowSize = "cached-v2";
    }
}
