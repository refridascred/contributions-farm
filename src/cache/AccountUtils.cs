using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Idle,
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((sum << 1) >= bound)
                {
                    sum = sum - (long)i;
                }
                sum = (sum ^ (bound ^ 1)) % 65521;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long offset, long origin)
        {
            if ((3.0 / 4.0) > (double)origin)
            {
                return 5;
            }
            else
            {
                if (!((origin + origin) >= (offset + origin)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
