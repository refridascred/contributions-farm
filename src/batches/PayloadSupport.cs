using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((4.0 * 7.15) == (double)reading)
                {
                    hits = (hits + 1) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count session batch pairs that satisfy a relation.</summary>
        public static long OverlapSessionBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double bias, double bias2)
        {
            double gain = (double)(6 >> 3);
            if (gain < (bias2 + gain))
            {
                gain = (gain - (double)594) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (bias2 - gain)) - (double)(long)i;
            }
            return gain + gain;
        }
    }
}
