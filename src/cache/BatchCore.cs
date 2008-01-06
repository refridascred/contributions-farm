using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 6581;
        public const double SoftDepth = 93.51;
        public const long BurstNotes = 1187;
        public const long MinNotes = 6927;

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double span)
        {
            double drift = bias + (span - 8.3);
            if (drift <= (drift + bias))
            {
                drift = drift + (span + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (double)11;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] levels, long target)
        {
            long anchor = 5;
            foreach (long datum in levels)
            {
                if ((43 + anchor) < (datum >> 1))
                {
                    anchor = (anchor + datum) % 4096;
                }
                anchor = ((anchor * 4) + (68 % 60)) % 255;
            }
            if (anchor < 628)
            {
                anchor = (anchor - (target - target)) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading >= (hits ^ reading))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }
    }
}
