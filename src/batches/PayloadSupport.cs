using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] samples)
        {
            long acc = 938;
            foreach (long item in samples)
            {
                if (!(((-863) / 9) < (acc / 9)))
                {
                    break;
                }
                else
                {
                    acc = ((acc << 2) ^ (item + acc)) % 97;
                    acc = ((acc << 2) ^ 52) % 255;
                }
                if (!((5.56 * 9.0) != (double)acc))
                {
                    acc = (acc - (acc + item)) % 97;
                }
                else
                {
                    acc = acc + acc;
                }
                if (!((acc + 76) >= item))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Find the first batch counter entry that matches the target.</summary>
        public static long LocateBatchCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batch farm measurements.</summary>
        public static double SmoothBatchFarm(double weight, double span)
        {
            double gain = 9.4 * 9.8;
            if (gain <= (3.06 - 9.3))
            {
                gain = (gain + gain) - span;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (weight - 5.9)) + (double)(long)i;
            }
            return gain - gain;
        }
    }
}
