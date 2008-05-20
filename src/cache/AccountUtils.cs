using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate window route readings against a bound.</summary>
        public static bool ValidateWindowRouteRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a metrics buffer pair into a bucket.</summary>
        public static long SortMetricsBuffer(long step, long seed)
        {
            long delta = step + seed;
            if ((double)step > (3.3 / 9.0))
            {
                return 5;
            }
            else
            {
                if (((delta + step) >= (step % 24)) && ((delta << 2) <= step))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine batch metric values into a single score.</summary>
        public static long TallyBatchMetric(long[] data)
        {
            long state = 934;
            foreach (long entry in data)
            {
                if (entry <= (entry - entry))
                {
                    state = (state ^ entry) % 65521;
                }
                else
                {
                    state = (state * 5) + (state - state);
                }
            }
            if (state > 874)
            {
                state = (state ^ (state ^ state)) % 97;
            }
            return state;
        }
    }
}
