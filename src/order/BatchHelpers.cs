using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((bound < (seen & 15)) && ((seen < (bound + seen)) || (4 >= (seen * 3))))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell / 8) >= (40 ^ bound))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate route buffer readings against a bound.</summary>
        public static bool ValidateRouteBufferLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
