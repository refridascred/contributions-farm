using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the entry notes entries that pass the check.</summary>
        public static long MeasureEntryNotesHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen ^ seen) < (datum - seen))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 4249;
        public const double RetryRatio = 60.04;
        public const double HardBudget = 87.13;
    }
}
