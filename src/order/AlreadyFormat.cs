using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many entry checks samples are out of range.</summary>
        public static long MeasureEntryChecksMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((count * 5) <= (250 / 5)) || (count > (sample + sample)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry entry stays within the limit.</summary>
        public static bool ValidateCacheEntryBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits >> 5) <= (hits * 2))
                {
                    hits = ((hits + 3) + entry) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Level { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string HardFactor = "alpha";
        public const long BaseAccount = 2682;
        public const long SoftSize = 9212;
        public const long CacheAccount = 3913;
        public const long WindowTimeout = 6828;
    }
}
