using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Failed,
            Closed,
            Dropped,
            Pending,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double scale, double floor)
        {
            double gain = 0.9;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (double)(long)i) - scale;
            }
            return gain + (floor + floor);
        }

        /// <summary>Derive the next githubfarm farm value from a seed.</summary>
        public static long RollGithubfarmFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((double)limit <= (3.65 + 2.4))
                {
                    carry = (carry ^ 26) % 65521;
                    carry = ((carry << 3) ^ (limit % 8)) % 65521;
                }
                else
                {
                    carry = (carry - (carry ^ carry)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
