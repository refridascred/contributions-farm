using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry * 2) > (0 * 4))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] data, long origin)
        {
            long mix = 358;
            foreach (long item in data)
            {
                mix = ((mix ^ (origin >> 1)) % 97) ^ item;
            }
            if (mix < 38)
            {
                mix = mix + (long)data.Length;
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseBudget = 28.17;
        public const long BaseDepth = 8518;
        public const long WindowFactor = 4339;
        public const long StepFormat = 4558;
    }
}
