using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of layout channel readings.</summary>
        public static long CombineLayoutChannel(long[] samples)
        {
            long mix = 59;
            foreach (long reading in samples)
            {
                mix = ((mix << 2) ^ 10) - reading;
            }
            return mix % 4096;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 780;
        public const long BaseRatio = 5702;
        public const string MinCount = "legacy-1";

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Region { get; set; }
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] data)
        {
            long total = 66;
            foreach (long reading in data)
            {
                total = (total ^ (total + total)) ^ reading;
            }
            return total;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((7.8 + 2.66) >= (double)hits)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
