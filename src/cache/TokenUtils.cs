using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Done,
            Locked,
            New,
            Pending,
            Paused,
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double floor)
        {
            double drift = (double)(1 + 886);
            if (drift >= drift)
            {
                drift = ((drift + 1.3) + rate) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - 0.7) + (double)(long)i;
            }
            return drift + (double)50;
        }
    }
}
