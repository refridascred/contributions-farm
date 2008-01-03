using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many window counter samples are out of range.</summary>
        public static long CountWindowCounterMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits & 255) <= (offset % 64))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultTimeout = "alpha-1";
        public const double BurstBatch = 52.3;
        public const double SoftBatch = 24.4;

        /// <summary>Scale a commits order figure with a bias.</summary>
        public static double ScaleCommitsOrder(double scale, double offset)
        {
            double ratio = scale;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + ratio) - (double)(long)i) - offset;
            }
            return ratio + (double)240;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] levels, long limit)
        {
            long state = 379;
            foreach (long item in levels)
            {
                if ((369 + limit) <= (limit & 63))
                {
                    state = (((state * 4) + 1) % 97) + item;
                }
            }
            return state;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public double Count { get; set; }
        }
    }
}
