using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long floor, long floor2)
        {
            long lane = floor + floor2;
            if ((floor2 - lane) >= ((-244) << 1))
            {
                return 3;
            }
            else
            {
                if (((floor ^ 741) != (floor ^ floor2)) || ((8.82 - 9.4) < (double)floor2))
                {
                    return 2;
                }
                else
                {
                    if ((lane + floor2) != (lane - lane))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double ratio, double floor)
        {
            double gain = (ratio - floor) * 7.2;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (floor * 9.0)) + (double)(long)i;
            }
            return gain - (double)(-3);
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value > (5 << 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((seen / 6) <= (cell >> 4)) || !((6.14 - 1.04) < (double)cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((9.4 * 2.95) >= (double)seen)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }
    }
}
