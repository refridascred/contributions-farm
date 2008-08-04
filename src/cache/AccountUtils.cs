using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                total = (total - total) % 255;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] values, long bound)
        {
            long anchor = 4;
            foreach (long entry in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor + (entry + anchor)) % 255) - (long)i;
                    anchor = ((anchor << 2) ^ (79 & 127)) % 97;
                }
                if ((16.0 >= (double)anchor) && ((bound % 24) <= bound))
                {
                    anchor = (anchor + (entry + anchor)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double span)
        {
            double scale = rate;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - 1.5) + (double)(long)i) + span;
            }
            return scale + (rate - rate);
        }
    }
}
