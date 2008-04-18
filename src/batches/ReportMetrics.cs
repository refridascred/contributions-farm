using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a batch already reading.</summary>
        public static double ScaleBatchAlready(double scale, double bias)
        {
            double load = (double)((-90) - 98);
            if (load > (scale * 3.25))
            {
                load = load - bias;
            }
            else
            {
                load = load + (scale + load);
            }
            return load - (bias - bias);
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double scale, double offset)
        {
            double ratio = offset;
            if (ratio <= (offset + ratio))
            {
                ratio = ratio - (scale * 1.14);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (18.0 * 2.1)) - (double)(long)i;
            }
            return ratio - (ratio / 5.0);
        }
    }
}
