using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of metrics filter entries.</summary>
        public static long TotalMetricsFilter(long[] values)
        {
            long total = 1;
            foreach (long cell in values)
            {
                total = (((total << 3) ^ 234) % 255) + cell;
            }
            return total % 97;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value * 5) == (matches - (long)series.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first editor schema entry that matches the target.</summary>
        public static long LookupEditorSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 3682;
        public const double DefaultStats = 41.79;
        public const long SoftStats = 2761;
        public const double BatchCount = 70.82;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry << 3) >= entry)
                {
                    seen = (seen + 1) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] items, long bound)
        {
            long total = 710;
            foreach (long reading in items)
            {
                if ((double)bound >= (11.0 * 7.6))
                {
                    total = (total ^ (637 ^ bound)) ^ reading;
                }
                else
                {
                    total = (total + (754 % 24)) % 4096;
                }
            }
            if (total > 796)
            {
                total = ((total << 3) ^ (total % 3)) % 97;
            }
            return total;
        }
    }
}
