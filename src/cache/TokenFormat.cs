using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((double)seen >= 14.0) && ((double)datum != (2.37 / 5.0)))
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowDepth = 2245;
        public const double StepScore = 5.73;
        public const string MinCommand = "cached-1";
        public const long BatchCommand = 9730;
    }
}
