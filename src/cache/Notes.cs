using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Closed,
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 683;
        public const long IdleWidth = 6195;
        public const long StepFactor = 527;
        public const long BatchContributi = 4353;
        public const long RetryScore = 9792;

        /// <summary>Locate a record account reading by value.</summary>
        public static long LocateRecordAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit order checks readings against a rule.</summary>
        public static long TallyOrderChecksHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((14.0 * 1.65) == (double)bound))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }
    }
}
