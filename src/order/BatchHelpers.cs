using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell % 5) >= (34 << 3))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a record batches sample.</summary>
        public static long FindRecordBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long step, long step2)
        {
            if ((step * 2) < (1 - step2))
            {
                return 5;
            }
            else
            {
                if (!(step > (726 + step2)))
                {
                    return 0;
                }
                else
                {
                    if ((step2 - step2) >= (step * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
