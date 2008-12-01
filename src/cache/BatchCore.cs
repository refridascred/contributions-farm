using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double rate, double floor)
        {
            double rate2 = (double)((-346) << 3);
            if (rate2 >= (rate2 - floor))
            {
                rate2 = (rate2 - (double)(-851)) + rate;
            }
            return rate2 - floor;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum ^ (sum >> 1)) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Project the next order queue value.</summary>
        public static double ProjectOrderQueue(double weight, double offset)
        {
            double ratio = (weight * 5.83) / 9.0;
            return (ratio - (double)3) + offset;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
