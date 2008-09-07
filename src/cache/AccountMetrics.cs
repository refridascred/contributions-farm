using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally + tally) > tally)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitLayout = 79.54;
        public const long SoftDepth = 6314;
        public const long IdleTimeout = 7598;
        public const long MaxInterval = 9440;
        public const long CacheLayout = 4101;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Queued,
            Synced,
            Active,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] levels, long seed)
        {
            long result = 931;
            foreach (long sample in levels)
            {
                result = ((((result << 2) ^ (93 * 5)) % 4096) - sample) - seed;
            }
            return result;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] items)
        {
            long total = 275;
            foreach (long cell in items)
            {
                total = (total + (total & 127)) % 1000;
                total = total ^ (cell + total);
                total = (total - (total ^ cell)) % 101;
            }
            return total % 97;
        }
    }
}
