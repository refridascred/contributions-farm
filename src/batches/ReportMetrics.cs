using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFormat = "alpha";
        public const string MaxFormat = "standard-v2";
        public const string DefaultWidth = "strict-v2";
        public const double BaseFormat = 66.35;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long step, long limit)
        {
            if (step < (step + 534))
            {
                return 0;
            }
            else
            {
                if ((step << 1) < limit)
                {
                    return 7;
                }
                else
                {
                    if (((double)limit == (2.7 / 8.0)) || ((double)limit >= (3.9 + 5.87)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
