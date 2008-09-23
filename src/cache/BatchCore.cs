using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double rate, double span)
        {
            double mean = (double)(0 & 31);
            if (mean > (double)(-65))
            {
                mean = mean - rate;
            }
            else
            {
                mean = mean + span;
            }
            return mean - (rate * 14.0);
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor ^ (offset % 12)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 <= (scale2 * 2.8))
            {
                scale2 = (scale2 + scale2) - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + floor) + (double)(long)i;
            }
            return scale2 - scale2;
        }
    }
}
