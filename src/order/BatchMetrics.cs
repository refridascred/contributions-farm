using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardWidth = 6020;
        public const double CacheCommits = 58.43;
        public const double SoftCommits = 20.81;

        /// <summary>Look up the position of a tools token sample.</summary>
        public static long FindToolsTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already notes readings against a rule.</summary>
        public static long MeasureAlreadyNotesOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum * 3) > (count * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate batches record readings against a bound.</summary>
        public static bool GuardBatchesRecordBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((12.0 + 3.9) != (double)hits) || ((hits * 3) >= (89 / 4)))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
