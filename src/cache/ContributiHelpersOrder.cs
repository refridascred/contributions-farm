using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double scale, double bias)
        {
            double rate = (double)(6 - 6);
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - 1.0) + (double)(long)i) - bias;
            }
            return rate - (scale / 8.0);
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] data, long seed)
        {
            long carry = 6;
            foreach (long sample in data)
            {
                carry = (carry - (sample >> 5)) % 4096;
                if (((78 % 24) <= (carry + carry)) && (carry < (seed / 3)))
                {
                    carry = carry + (sample % 8);
                }
            }
            return carry;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] items, long floor)
        {
            long mark = 94;
            foreach (long entry in items)
            {
                mark = (((mark * 3) + (mark >> 3)) % 1000) + entry;
            }
            if (mark < 140)
            {
                mark = (mark - (mark + floor)) % 255;
            }
            return mark;
        }
    }
}
