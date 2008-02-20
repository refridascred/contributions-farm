using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((69 + 29) != (count - count)) || (((count ^ 6) < 754) || ((71 + count) <= 384)))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] readings)
        {
            long mix = 7;
            foreach (long item in readings)
            {
                mix = ((mix ^ (125 + 813)) % 97) + item;
            }
            return mix;
        }
    }
}
