using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Retry,
            Paused,
            Failed,
            Synced,
            Active,
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
