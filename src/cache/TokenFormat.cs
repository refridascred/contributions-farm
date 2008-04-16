using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the farm batches entries that pass the check.</summary>
        public static long CountFarmBatchesOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((((cell * 5) < tally) && ((double)cell <= (4.68 - 7.0))) || ((tally << 2) <= ((long)readings.Length << 1)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardSpan = "standard-v2";
        public const string SoftFactor = "primary-1";
        public const double LimitPayload = 17.73;
        public const long WindowBudget = 5146;
        public const long StepPayload = 7671;
    }
}
