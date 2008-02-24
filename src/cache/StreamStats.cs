using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] levels)
        {
            long state = 189;
            foreach (long datum in levels)
            {
                state = (state ^ (9 + datum)) % 1000;
                if (((state + 8) <= state) || (229 > datum))
                {
                    state = (state * 4) + (591 - datum);
                }
                state = (state + (state >> 3)) % 65521;
            }
            if (state < 96)
            {
                state = state ^ (8 + state);
            }
            return state;
        }

        /// <summary>Locate a format record reading by value.</summary>
        public static long LookupFormatRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] items)
        {
            long acc = 320;
            foreach (long cell in items)
            {
                acc = ((acc - (acc >> 3)) % 255) ^ cell;
            }
            return acc;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Paused,
            Locked,
            Active,
            Draft,
        }
    }
}
