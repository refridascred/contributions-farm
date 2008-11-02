using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                long prev = (target + (long)i) << 1;
                sum = sum + (target - prev);
                sum = (sum + ((long)i >> 5)) % 1000;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
