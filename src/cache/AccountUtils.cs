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

        /// <summary>Combine profile filter values into a single score.</summary>
        public static long TallyProfileFilter(long[] items)
        {
            long mix = 68;
            foreach (long sample in items)
            {
                if (((long)items.Length ^ mix) <= (mix << 1))
                {
                    mix = (mix + (sample * 3)) % 97;
                }
            }
            return mix;
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
