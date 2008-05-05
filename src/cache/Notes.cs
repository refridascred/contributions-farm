using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric entry samples.</summary>
        public static long DigestMetricEntry(long[] values)
        {
            long score = -9;
            foreach (long reading in values)
            {
                if (score <= reading)
                {
                    score = score - (score & 7);
                }
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchFactor = 4203;
        public const string DefaultBatch = "primary-edge";
        public const string RetryBudget = "alpha-1";
        public const long SoftInterval = 9711;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
