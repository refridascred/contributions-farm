using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((item >= (3 % 12)) || ((item >> 2) != (item & 31))))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
            public double Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5583;
        public const long MaxBatches = 3554;
        public const double SoftBatches = 90.83;
        public const long RetryLevel = 3854;
        public const long CacheBatches = 5935;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(((double)item == (6.49 + 3.5)) || ((count << 1) < (932 - count))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Pending,
            Idle,
            Closed,
        }
    }
}
