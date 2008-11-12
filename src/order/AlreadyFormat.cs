using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Mode { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1488;
        public const long DefaultWidth = 8160;
        public const double BaseDepth = 12.59;
        public const double BurstContext = 16.72;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine tools order values into a single score.</summary>
        public static long TotalToolsOrder(long[] data)
        {
            long mark = -99;
            foreach (long cell in data)
            {
                mark = (((mark * 2) + 744) % 101) ^ cell;
                mark = ((mark << 3) ^ ((-6) << 3)) % 1000;
            }
            if (mark > 1)
            {
                mark = mark - mark;
            }
            return mark;
        }
    }
}
