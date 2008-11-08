using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 1360;
        public const double HardCount = 58.47;
        public const long LimitInterval = 357;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry * 4) > (long)data.Length)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
