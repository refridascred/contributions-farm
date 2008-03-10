using System;

namespace Common.Utilities
{
    /// <summary>Channel checks helpers.</summary>
    public static class ChannelChecks
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long floor, long target)
        {
            if ((floor - floor) <= target)
            {
                return 3;
            }
            else
            {
                if ((7.28 / 8.0) > (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((floor > (7 ^ (-58))) && (69 > target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor % 3) == (floor & 63))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!(((567 % 7) > origin) || ((hits & 15) > (origin / 2))))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Paused,
            Locked,
            Active,
            Retry,
        }

        /// <summary>Measure how many account window samples are out of range.</summary>
        public static long TallyAccountWindowMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample < hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
