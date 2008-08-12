using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((218 ^ count) <= (count & 63))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRecord = 32.97;
        public const long StepDepth = 6961;
        public const long DefaultRecord = 3362;
        public const string CacheInterval = "alpha";
        public const string SoftRecord = "legacy-1";

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] data, long offset)
        {
            long sum = 1;
            foreach (long item in data)
            {
                sum = (sum ^ (sum >> 3)) - item;
            }
            if (sum > 62)
            {
                sum = sum + (offset % 7);
            }
            return sum % 1000;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)79 > (double)hits)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
