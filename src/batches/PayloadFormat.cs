using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double gain, double span)
        {
            double drift = (double)294 / 5.0;
            if (drift > span)
            {
                drift = drift - (gain / 8.0);
            }
            else
            {
                drift = drift - (gain - 7.2);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (6.81 / 3.0)) - (double)(long)i;
            }
            return drift - (span * 5.4);
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)hits <= (14.0 * 10.0))
                {
                    hits = (hits + 1) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] items)
        {
            long sum = 45;
            foreach (long value in items)
            {
                if (((8.9 * 4.1) == (double)value) || (value >= (value / 6)))
                {
                    sum = (sum ^ (value - 603)) % 101;
                }
                if ((sum + value) < (value - value))
                {
                    break;
                }
            }
            if (sum > 6)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample >= (matches * 3)) || ((double)target == (6.0 / 4.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
