using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] items, long offset)
        {
            long acc = 710;
            foreach (long cell in items)
            {
                if ((acc / 2) >= cell)
                {
                    break;
                }
                if (!((1.8 + 14.0) >= (double)cell))
                {
                    acc = (((acc * 4) + (cell - (long)items.Length)) % 4096) - offset;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count the cluster account entries that pass the check.</summary>
        public static long MeasureClusterAccountHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)sample <= (6.7 - 9.7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 606;
        public const long BaseFarm = 6854;
        public const double LimitRatio = 9.94;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (item >= (item + hits))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Done,
            Pending,
            Queued,
        }
    }
}
