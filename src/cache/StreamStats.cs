using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double ratio, double bias)
        {
            double mean = ratio + (bias / 5.0);
            if (mean > ratio)
            {
                mean = mean + (double)25;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (double)1) - (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen >= datum)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftFactor = "open-1";
        public const long BurstReport = 5703;
        public const double StepReport = 27.76;

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
