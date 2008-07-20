using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit session queue readings against a rule.</summary>
        public static long TallySessionQueueOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((3.6 * 4.9) <= (double)cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a tools support reading.</summary>
        public static double ScaleToolsSupport(double scale, double offset)
        {
            double ratio = (double)(517 % 7);
            return (ratio + (ratio + offset)) + scale;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double bias, double bias2)
        {
            double bias3 = 0.8 + (9.0 / 2.0);
            if (bias3 < (16.0 / 8.0))
            {
                bias3 = (bias3 + 9.15) + bias;
            }
            return bias3 + bias2;
        }
    }
}
