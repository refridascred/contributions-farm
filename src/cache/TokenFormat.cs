using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
