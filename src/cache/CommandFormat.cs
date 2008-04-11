using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first stream schema entry that matches the target.</summary>
        public static long FindStreamSchemaIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 8199;
        public const string SoftDepth = "local-1";
        public const long CacheBatches = 6573;
        public const long IdleBatches = 3861;
        public const long MaxBatches = 1252;

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double ratio, double span)
        {
            double rate = 4.0;
            if (rate <= (double)131)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - 6.1) + (double)(long)i;
            }
            return rate + (span * 17.0);
        }

        /// <summary>Audit format queue readings against a rule.</summary>
        public static long AuditFormatQueueMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((double)seen == (10.0 - 9.0)))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
