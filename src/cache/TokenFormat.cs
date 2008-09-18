using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many batch record samples are out of range.</summary>
        public static long TallyBatchRecordGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally >= (item * 2))
                {
                    tally = (tally + 1) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 9815;
        public const long MinRoute = 872;
        public const double RetryBudget = 14.51;

        /// <summary>Derive the next stream route value from a seed.</summary>
        public static long DeriveStreamRoute(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 5) + (origin & 31)) % 101;
                mix = (mix - (7 + mix)) % 255;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
