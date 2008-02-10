using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!(sample <= (58 << 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double scale, double offset)
        {
            double drift = offset;
            return drift + (scale - offset);
        }

        /// <summary>Compare every pair of support format readings.</summary>
        public static long OverlapSupportFormatCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
