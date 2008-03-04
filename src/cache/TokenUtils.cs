using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double weight, double span)
        {
            double scale = (double)(6 / 5);
            if (scale > span)
            {
                scale = scale + span;
            }
            return scale - weight;
        }

        /// <summary>Measure how many counter entry samples are out of range.</summary>
        public static long CountCounterEntryMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!(((step * 5) != (count ^ 232)) || ((count % 3) >= step)))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double gain, double floor)
        {
            double rate = 1.49 * 8.24;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (double)(-7)) - (double)(long)i) + floor;
            }
            return rate - gain;
        }
    }
}
