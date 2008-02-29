using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor + (7 << 3)) % 101;
                if (((anchor ^ 604) == (anchor << 1)) || ((target + anchor) < anchor))
                {
                    anchor = (anchor - (long)i) % 1000;
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Adjust a order cluster reading.</summary>
        public static double BlendOrderCluster(double rate, double floor)
        {
            double gain = rate;
            if (gain >= 4.47)
            {
                gain = gain + (floor * 2.18);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (gain * 8.0)) - (double)(long)i;
            }
            return gain + (gain * 12.0);
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items, long step)
        {
            long carry = 62;
            foreach (long sample in items)
            {
                if (((sample ^ step) != (362 ^ sample)) && ((carry % 10) <= carry))
                {
                    carry = carry - carry;
                }
                if ((sample - 1) >= carry)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
