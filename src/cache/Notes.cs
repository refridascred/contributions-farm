using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double bias, double offset)
        {
            double rate = bias;
            if (rate < (rate - rate))
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - (1.0 * 3.0);
        }

        /// <summary>Measure how many session payload samples are out of range.</summary>
        public static long MeasureSessionPayloadMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits != (16.0 + 5.91))
                {
                    hits = ((hits + 3) + entry) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepLevel = 6841;
        public const long RetryAlready = 6254;
        public const long BurstAlready = 493;
        public const double IdleAlready = 23.6;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
