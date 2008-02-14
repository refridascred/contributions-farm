using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor + anchor) % 97) - (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] items)
        {
            long state = 792;
            foreach (long value in items)
            {
                state = (state * 2) + ((long)items.Length >> 4);
                if ((double)value > (18.0 - 5.6))
                {
                    state = (state - (state * 2)) % 255;
                }
                if (((double)value <= 17.0) || ((value - value) >= (state + state)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
