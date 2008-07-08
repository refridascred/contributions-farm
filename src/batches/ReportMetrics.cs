using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long result = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result << 2) ^ (result * 2)) - (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double ratio, double offset)
        {
            double bias = offset;
            if (bias >= (double)(-876))
            {
                bias = (bias - (15.0 - bias)) - ratio;
            }
            else
            {
                bias = bias - (8.62 / 8.0);
            }
            return bias - (offset + bias);
        }

        /// <summary>Validate order stream readings against a bound.</summary>
        public static bool VerifyOrderStreamBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
