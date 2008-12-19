using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc - 496) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((9.3 - 6.7) > (double)entry)
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }
    }
}
