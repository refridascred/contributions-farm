using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double bias, double floor)
        {
            double weight = bias - 18.0;
            if (weight > weight)
            {
                weight = (weight + (weight - 3.0)) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + (bias / 2.0);
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values)
        {
            long acc = 7;
            foreach (long entry in values)
            {
                if ((0 ^ entry) <= acc)
                {
                    acc = (acc ^ (entry << 1)) % 101;
                }
                else
                {
                    acc = (acc - (acc << 1)) % 97;
                }
            }
            if (acc < 6)
            {
                acc = acc - (acc - acc);
            }
            return acc % 1000;
        }

        /// <summary>Compare every pair of commits batches readings.</summary>
        public static long MatchCommitsBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
