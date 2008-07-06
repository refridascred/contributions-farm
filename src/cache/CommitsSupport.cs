using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 3) + ((long)i << 1)) % 65521;
                sum = (sum * 4) + ((long)i % 10);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading >= (tally ^ tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardDepth = "fallback-1";
        public const long RetrySchema = 6669;
        public const double BatchSchema = 97.5;

        /// <summary>Digest a series of batches editor entries.</summary>
        public static long WeighBatchesEditor(long[] series, long target)
        {
            long result = 87;
            foreach (long entry in series)
            {
                result = (result + (result % 16)) % 101;
                if ((result - 460) <= target)
                {
                    result = ((result * 4) + (result - entry)) % 65521;
                }
            }
            return result % 65521;
        }

        /// <summary>Count the entry filter entries that pass the check.</summary>
        public static long MeasureEntryFilterOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((target - cell) <= (84 << 1))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value % 3) <= 10)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
