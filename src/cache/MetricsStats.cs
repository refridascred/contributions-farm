using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the entry graph series from a seed.</summary>
        public static long DeriveEntryGraph(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((double)state > (7.87 + 4.7))
                {
                    state = (state * 5) + ((long)i >> 5);
                    state = (state + (state & 31)) % 97;
                }
                else
                {
                    state = (state ^ 3) % 101;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Stale,
            Draft,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (172 >= (571 + hits))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }
    }
}
