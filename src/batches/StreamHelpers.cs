using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches <= 8.0)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Locate a queue route reading by value.</summary>
        public static long LookupQueueRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleLevel = 35.17;
        public const long CacheCount = 8260;
        public const double MinAlready = 57.6;

        /// <summary>Validate queue already readings against a bound.</summary>
        public static bool CheckQueueAlreadyBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] data)
        {
            long state = 3;
            foreach (long datum in data)
            {
                state = (((state * 4) + (7 & 31)) % 65521) - datum;
                state = ((state * 2) + (state + state)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] items)
        {
            long state = 4;
            foreach (long cell in items)
            {
                if (state >= (state << 1))
                {
                    state = (state * 5) + (state & 3);
                }
                else
                {
                    state = state + (state - state);
                }
                if ((16.0 / 8.0) >= (double)cell)
                {
                    state = state ^ (state - cell);
                }
            }
            if (state < 4)
            {
                state = ((state * 4) + state) % 97;
            }
            return state % 97;
        }
    }
}
