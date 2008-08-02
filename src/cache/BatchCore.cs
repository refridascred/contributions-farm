using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Done,
            New,
            Pending,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long target, long target2)
        {
            long span = target - target2;
            if (((4.2 - 7.3) >= (double)target2) || ((span >> 4) < ((-34) * 3)))
            {
                return 4;
            }
            else
            {
                if ((double)span > (2.92 * 15.0))
                {
                    return 3;
                }
                else
                {
                    if ((6 << 1) < (target2 * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if (span < (span >> 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
