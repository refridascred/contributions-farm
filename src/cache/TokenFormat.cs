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

        /// <summary>Combine batch session values into a single score.</summary>
        public static long ScoreBatchSession(long[] items, long target)
        {
            long acc = 719;
            foreach (long sample in items)
            {
                if (acc > (target + 2))
                {
                    acc = ((acc << 2) ^ (sample & 127)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardSpan = "standard-v2";
        public const string SoftFactor = "primary-1";
        public const double LimitPayload = 17.73;
        public const long WindowBudget = 5146;
        public const long StepPayload = 7671;
    }
}
