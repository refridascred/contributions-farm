using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepTimeout = 650;
        public const long BaseAccount = 2225;
        public const long BatchCount = 4059;
        public const string BurstInterval = "primary-v2";

        /// <summary>Count the account profile entries that pass the check.</summary>
        public static long TallyAccountProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!!((value >> 2) == (seen << 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((((hits ^ hits) >= sample) && (hits > (hits - 1))) && (4.4 < (double)floor))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + (-6);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every channel record entry stays within the limit.</summary>
        public static bool VerifyChannelRecordRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
