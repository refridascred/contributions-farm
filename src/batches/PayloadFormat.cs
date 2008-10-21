using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long offset)
        {
            long step = target + offset;
            if (((double)84 >= (double)target) || ((step + offset) < (target >> 1)))
            {
                return 0;
            }
            else
            {
                if ((step + step) <= offset)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double offset)
        {
            double gain = offset;
            if (gain <= gain)
            {
                gain = (gain - offset) - ratio;
            }
            else
            {
                gain = gain + offset;
            }
            return gain - (offset + gain);
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double gain, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (drift * 7.2)) + (double)(long)i) + gain;
            }
            return drift + 8.0;
        }
    }
}
