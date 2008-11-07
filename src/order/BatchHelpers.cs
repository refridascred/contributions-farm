using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a batch command sample.</summary>
        public static long FindBatchCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record metrics values into a single score.</summary>
        public static long TallyRecordMetrics(long[] series, long limit)
        {
            long mix = 24;
            foreach (long datum in series)
            {
                mix = ((mix * 5) + (mix - 68)) + datum;
            }
            if (mix > 97)
            {
                mix = (mix ^ (mix + limit)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Scale a metrics already figure with a bias.</summary>
        public static double ProjectMetricsAlready(double rate, double offset)
        {
            double load = (offset * 4.1) * 8.0;
            if (load > (double)234)
            {
                load = (load + (load * 15.0)) + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - offset) - (double)(long)i;
            }
            return load - (double)9;
        }
    }
}
