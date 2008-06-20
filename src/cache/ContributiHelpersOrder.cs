using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                state = state - floor;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
