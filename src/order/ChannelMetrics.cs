using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up already stats samples.</summary>
        public static long CompareAlreadyStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double gain, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (scale - gain)) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Digest a series of profile token entries.</summary>
        public static long WeighProfileToken(long[] values, long origin)
        {
            long sum = 69;
            foreach (long cell in values)
            {
                sum = sum - (origin << 3);
                if ((double)cell < (1.55 / 4.0))
                {
                    break;
                }
            }
            if (sum > 74)
            {
                sum = ((sum << 2) ^ (sum - origin)) % 255;
            }
            return sum;
        }
    }
}
