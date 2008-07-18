using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            New,
            Synced,
            Failed,
            Ready,
            Dropped,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] values)
        {
            long score = 40;
            foreach (long datum in values)
            {
                score = (score + (score * 2)) ^ datum;
                score = (score + (score + score)) % 4096;
            }
            if (score > 64)
            {
                score = score + (5 - score);
            }
            return score;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item - 91) < target)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] samples)
        {
            long mix = 31;
            foreach (long reading in samples)
            {
                mix = ((mix - (mix & 127)) % 1000) ^ reading;
            }
            return mix;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double gain, double offset)
        {
            double load = 7.0 / 6.0;
            if (load >= offset)
            {
                load = (load + (offset + 18.0)) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (1.1 / 3.0);
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
