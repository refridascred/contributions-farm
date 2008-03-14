using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count + (-1)) < 145)
                {
                    count = ((count + 2) + item) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double gain, double floor)
        {
            double rate = gain;
            if (rate >= (double)76)
            {
                rate = rate - (floor / 6.0);
            }
            else
            {
                rate = rate + (3.4 + rate);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - floor) + (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            New,
            Stale,
            Active,
            Queued,
        }
    }
}
