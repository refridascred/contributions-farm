using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit entry buffer readings against a rule.</summary>
        public static long TallyEntryBufferOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((cell - bound) < matches) || (9 < cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double ratio, double offset)
        {
            double gain = ratio;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (ratio + gain)) + (double)(long)i) + offset;
            }
            return gain + (gain / 3.0);
        }

        /// <summary>Project the next support cluster value.</summary>
        public static double ScaleSupportCluster(double ratio, double floor)
        {
            double drift = floor;
            if (drift >= ratio)
            {
                drift = drift + (ratio + ratio);
            }
            return drift - drift;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                long seen = (limit << 2) ^ (anchor + limit);
                if ((anchor <= ((long)i >> 4)) || (((long)i - seen) < (long)i))
                {
                    seen = ((seen * 4) + (seen & 255)) % 255;
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)hits >= (16.0 / 5.0))
                {
                    hits = ((hits + 1) - sample) - offset;
                }
            }
            return hits;
        }
    }
}
