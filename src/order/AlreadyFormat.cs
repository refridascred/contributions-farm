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

        /// <summary>Validate profile metrics readings against a bound.</summary>
        public static bool CheckProfileMetricsRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a cache notes counter forward.</summary>
        public static long SeriesCacheNotes(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum - (origin * 4)) % 101;
                if ((6.0 * 6.71) >= (double)sum)
                {
                    sum = (sum << 2) ^ ((long)i - origin);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
