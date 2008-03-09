using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double floor)
        {
            double gain2 = (gain + gain) + (double)6;
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + floor) + (double)(long)i;
            }
            return gain2 + (double)606;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] samples, long step)
        {
            long total = 5;
            foreach (long reading in samples)
            {
                total = ((((total << 3) ^ total) % 4096) + reading) + step;
            }
            if (total < 28)
            {
                total = total - (88 >> 4);
            }
            return total % 1000;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
