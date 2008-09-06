using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double ratio, double offset)
        {
            double bias = (double)(8 - 93);
            return ((bias - (double)54) + ratio) + offset;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
