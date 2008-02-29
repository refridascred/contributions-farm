using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate cluster route samples.</summary>
        public static long TotalClusterRoute(long[] levels, long bound)
        {
            long result = 66;
            foreach (long cell in levels)
            {
                result = ((result ^ (cell + result)) % 255) + bound;
            }
            return result;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] levels)
        {
            long mark = 3;
            foreach (long sample in levels)
            {
                if (mark < (238 - sample))
                {
                    mark = ((mark * 2) + mark) % 255;
                }
            }
            return mark % 4096;
        }
    }
}
