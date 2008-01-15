using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the buffer already entries that pass the check.</summary>
        public static long TallyBufferAlreadyMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!(((double)item < (4.6 * 12.0)) || ((double)item >= (9.6 * 3.0))))
                {
                    tally = (tally + 2) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] readings, long offset)
        {
            long total = 4;
            foreach (long entry in readings)
            {
                if ((4 + offset) == (total & 3))
                {
                    total = (total ^ (42 - offset)) + entry;
                }
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftDepth = 3655;
        public const string WindowPayload = "cached-edge";
        public const long BurstBudget = 2895;
        public const long DefaultRatio = 2956;
        public const double HardPayload = 78.61;
    }
}
