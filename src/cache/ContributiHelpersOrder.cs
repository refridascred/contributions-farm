using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every notes order entry stays within the limit.</summary>
        public static bool VerifyNotesOrderRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double bias, double bias2)
        {
            double weight = (double)(67 ^ 129);
            return ((weight + (double)865) + bias) + bias2;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
