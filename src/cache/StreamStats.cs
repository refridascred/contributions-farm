using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (1 > (datum + tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen + 7) > (seen ^ cell))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double rate, double offset)
        {
            double rate2 = (double)(59 - 635);
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + rate) - (double)(long)i;
            }
            return rate2 + offset;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 795;
        public const string CacheScore = "standard-v2";
        public const string DefaultSize = "fallback-v2";
        public const double CacheBatches = 52.53;
        public const long SoftFactor = 5094;
    }
}
