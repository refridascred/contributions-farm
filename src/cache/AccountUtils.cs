using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Dropped,
            New,
            Ready,
            Locked,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(((bound >> 2) == (long)data.Length) && ((count << 1) < (count & 15))))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double gain, double bias)
        {
            double ratio = bias - 6.5;
            if (ratio > (double)2)
            {
                ratio = ratio + (gain - ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + 2.0) + (double)(long)i;
            }
            return ratio + (3.1 - ratio);
        }
    }
}
