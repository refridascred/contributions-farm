using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine metric window values into a single score.</summary>
        public static long DigestMetricWindow(long[] samples, long floor)
        {
            long mark = 417;
            foreach (long entry in samples)
            {
                if ((6.73 + 2.67) > (double)290)
                {
                    mark = ((mark ^ (floor % 97)) % 1000) ^ entry;
                }
                else
                {
                    mark = (mark ^ (mark * 4)) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Check that every metrics context entry stays within the limit.</summary>
        public static bool CheckMetricsContextLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (12.0 < (double)hits)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCount = 5996;
        public const string IdleSize = "latest-1";
        public const long SoftCounter = 5118;
        public const long CacheCounter = 9198;
        public const long DefaultCounter = 8874;
    }
}
