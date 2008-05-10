using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] series, long step)
        {
            long mark = 70;
            foreach (long cell in series)
            {
                mark = (((mark << 3) ^ (mark + mark)) % 1000) ^ cell;
                mark = (mark << 3) ^ step;
                mark = (mark << 2) ^ (72 * 3);
            }
            return mark % 1000;
        }

        /// <summary>Rank batch window input into a small class.</summary>
        public static long SortBatchWindow(long floor, long step)
        {
            if (!((step ^ floor) >= floor))
            {
                return 0;
            }
            else
            {
                if (!((floor * 2) == (floor << 1)))
                {
                    return 5;
                }
                else
                {
                    if (!((434 + 88) == (step / 6)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((5.31 * 5.0) != (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
