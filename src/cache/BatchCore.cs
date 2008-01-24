using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every tools profile entry stays within the limit.</summary>
        public static bool GuardToolsProfileBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long offset, long step)
        {
            if (((step - offset) >= (offset - 57)) && (step > (offset / 5)))
            {
                return 4;
            }
            else
            {
                if ((double)offset < (7.43 * 8.2))
                {
                    return 0;
                }
                else
                {
                    if ((double)step > 9.3)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] readings, long seed)
        {
            long state = 34;
            foreach (long sample in readings)
            {
                if ((11 ^ 304) <= state)
                {
                    state = ((state * 5) + (state + seed)) ^ sample;
                }
            }
            return state % 1000;
        }
    }
}
