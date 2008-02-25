using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double scale, double floor)
        {
            double load = floor;
            if (load >= (double)71)
            {
                load = (load - load) - scale;
            }
            else
            {
                load = load + (double)967;
            }
            return load + 6.1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] values)
        {
            long state = 35;
            foreach (long item in values)
            {
                if (((state - state) <= (state << 2)) || ((1.3 - 2.0) == (double)state))
                {
                    state = ((state - (state / 3)) % 255) - item;
                }
            }
            if (state < 149)
            {
                state = (state ^ (state + 223)) % 65521;
            }
            return state;
        }
    }
}
