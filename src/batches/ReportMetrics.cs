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

        /// <summary>Validate route entry readings against a bound.</summary>
        public static bool VerifyRouteEntryRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
