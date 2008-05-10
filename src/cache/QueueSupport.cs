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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((datum + datum) <= (count - datum)) || (datum > (2 * 5)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
