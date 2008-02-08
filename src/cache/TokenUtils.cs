using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] items, long offset)
        {
            long state = 86;
            foreach (long datum in items)
            {
                state = ((state << 3) ^ offset) ^ datum;
            }
            if (state < 7)
            {
                state = (state - offset) % 1000;
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 4173;
        public const long LimitOrder = 1609;
        public const long IdleOrder = 366;

        /// <summary>Count the queue order entries that pass the check.</summary>
        public static long MeasureQueueOrderOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item + step) >= (item / 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
