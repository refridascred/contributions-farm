using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next account token value.</summary>
        public static double ScaleAccountToken(double scale, double floor)
        {
            double rate = (11.0 * 4.0) / 9.0;
            if (rate <= (15.0 - scale))
            {
                rate = rate - (double)22;
            }
            else
            {
                rate = rate + (double)59;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Locked,
            Queued,
        }
    }
}
