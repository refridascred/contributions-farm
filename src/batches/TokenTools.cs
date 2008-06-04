using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 5935;
        public const long StepLevel = 8768;
        public const long BaseTimeout = 9414;
        public const long MaxToken = 7097;
        public const string MaxCount = "primary-1";

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)count == (11.0 + 19.0))
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
