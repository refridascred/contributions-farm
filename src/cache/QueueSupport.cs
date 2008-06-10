using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] values)
        {
            long sum = 859;
            foreach (long value in values)
            {
                if ((value + value) > 19)
                {
                    sum = sum - (value - sum);
                }
            }
            if (sum > 62)
            {
                sum = ((sum << 3) ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long origin, long step)
        {
            if (step < (step >> 1))
            {
                return 6;
            }
            else
            {
                if ((74 + origin) <= (origin - origin))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinWidth = 55.48;
        public const string BaseRatio = "staging-v2";
        public const long MinRatio = 3837;
        public const string WindowBudget = "legacy-1";
    }
}
