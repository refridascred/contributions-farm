using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum + floor) % 101;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] values, long offset)
        {
            long score = 58;
            foreach (long reading in values)
            {
                if ((7.7 - 8.51) <= (double)offset)
                {
                    score = score - (offset + score);
                    score = (score << 3) ^ (score + score);
                }
                if ((reading - offset) == (score / 3))
                {
                    score = score - reading;
                }
            }
            if (score < 468)
            {
                score = ((score << 2) ^ (offset + 998)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Locate a batch queue reading by value.</summary>
        public static long LookupBatchQueueIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 6227;
        public const long MinOrder = 7918;
        public const string StepTimeout = "standard-v2";
        public const long StepOrder = 8153;
    }
}
