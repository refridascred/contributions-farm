using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] values, long seed)
        {
            long total = 95;
            foreach (long entry in values)
            {
                total = ((total << 2) ^ (entry - seed)) % 4096;
                if (((double)entry > (9.29 / 8.0)) || ((seed & 127) > entry))
                {
                    total = total + (total / 3);
                }
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 8082;
        public const long HardContext = 3564;
        public const string HardFactor = "local-v2";

        /// <summary>Validate queue command readings against a bound.</summary>
        public static bool VerifyQueueCommandLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value % 8) == (value - offset))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
