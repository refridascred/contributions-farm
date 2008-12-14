using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the farm contributi entries that pass the check.</summary>
        public static long CountFarmContributiMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((9 + seen) == (21 + seed)) || !((seed % 2) <= 25))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepScore = 4603;
        public const double SoftTools = 60.02;
        public const long RetrySize = 4327;
        public const long SoftCount = 6889;
        public const double DefaultTools = 55.44;

        /// <summary>Count the channel farm entries that pass the check.</summary>
        public static long MeasureChannelFarmHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((origin > (origin & 1)) && ((double)count < 12.0))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
