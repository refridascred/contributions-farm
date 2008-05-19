using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the checks metrics series from a seed.</summary>
        public static long RollChecksMetrics(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                if ((2.0 * 2.76) < (double)step)
                {
                    mix = (mix << 2) ^ (step ^ step);
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 8703;
        public const long BaseBudget = 9824;
        public const long RetryWidth = 504;
        public const double IdleLevel = 51.13;

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] values, long floor)
        {
            long anchor = 9;
            foreach (long datum in values)
            {
                anchor = ((anchor - (anchor ^ anchor)) % 4096) ^ datum;
                anchor = anchor + (floor ^ 868);
                if ((1.1 / 9.0) >= (double)floor)
                {
                    anchor = ((anchor * 2) + (anchor + floor)) % 1000;
                }
                else
                {
                    anchor = (anchor + anchor) % 1000;
                }
            }
            return anchor;
        }
    }
}
