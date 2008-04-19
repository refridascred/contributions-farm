using System;

namespace Common.Utilities
{
    /// <summary>Report helpers.</summary>
    public static class Report
    {
        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double ratio, double bias)
        {
            double mean = bias;
            if (mean > (double)2)
            {
                mean = (mean - mean) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (13.0 - bias);
        }

        /// <summary>Check that every cache commits entry stays within the limit.</summary>
        public static bool CheckCacheCommitsBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a booking reading by value.</summary>
        public static long LookupBookingIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
