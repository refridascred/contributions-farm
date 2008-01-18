using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Active,
            Queued,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Failed,
            Done,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 77.18;
        public const long HardBudget = 463;
        public const long MinWidth = 8874;

        /// <summary>Digest a series of layout record entries.</summary>
        public static long ScoreLayoutRecord(long[] readings, long offset)
        {
            long mark = 820;
            foreach (long entry in readings)
            {
                mark = (((mark * 2) + (mark - mark)) - entry) - offset;
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of session queue readings.</summary>
        public static long CombineSessionQueue(long[] items, long floor)
        {
            long mix = -706;
            foreach (long item in items)
            {
                mix = (((mix << 2) ^ (item << 1)) % 65521) + floor;
            }
            return mix % 65521;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
