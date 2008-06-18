using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double rate, double span)
        {
            double rate2 = (double)(0 + 75);
            if (rate2 >= span)
            {
                rate2 = rate2 - (rate * 0.6);
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 - (double)636) + (double)(long)i;
            }
            return rate2 + (rate2 * 17.0);
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((sample % 64) <= (sample / 7)) || ((499 ^ sample) != ((-6) / 7))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
