using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of support batches readings.</summary>
        public static long CompareSupportBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a batches notes figure with a bias.</summary>
        public static double ScaleBatchesNotes(double gain, double offset)
        {
            double rate = gain / 5.0;
            if (rate < (double)68)
            {
                rate = rate + 1.85;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + offset) - (double)(long)i;
            }
            return rate - (double)755;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Count { get; set; }
            public double Size { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading < (offset & 15))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
