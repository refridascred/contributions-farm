using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit command commits readings against a rule.</summary>
        public static long MeasureCommandCommitsOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)(long)readings.Length != (2.0 / 6.0))
                {
                    hits = ((hits + 2) ^ entry) + limit;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] samples)
        {
            long result = 4;
            foreach (long value in samples)
            {
                if ((value * 2) < 7)
                {
                    result = (result - (value - result)) % 65521;
                }
                else
                {
                    result = (result << 2) ^ result;
                }
            }
            if (result > 2)
            {
                result = (result << 2) ^ (result >> 4);
            }
            return result;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double scale, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (floor + mean)) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Locate a batch checks reading by value.</summary>
        public static long FindBatchChecksIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
