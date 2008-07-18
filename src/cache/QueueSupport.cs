using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = (total ^ total) % 101;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "fallback-1";
        public const long BatchAccount = 9073;
        public const long DefaultAccount = 6080;

        /// <summary>Fold a list of batch stats readings.</summary>
        public static long TotalBatchStats(long[] readings, long target)
        {
            long state = 9;
            foreach (long value in readings)
            {
                if ((target + target) >= state)
                {
                    state = ((state ^ (target - target)) % 1000) ^ value;
                }
            }
            if (state < 9)
            {
                state = state - (target / 3);
            }
            return state;
        }
    }
}
