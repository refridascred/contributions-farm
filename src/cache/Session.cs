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

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long target, long floor)
        {
            if (floor < (4 - target))
            {
                return 0;
            }
            else
            {
                if (!((floor / 7) > floor))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
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
