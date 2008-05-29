using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long seed, long bound)
        {
            if ((834 % 97) != (bound + seed))
            {
                return 3;
            }
            else
            {
                if ((30 ^ seed) >= (seed & 1))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (datum > (seed + seed))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
