using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits <= (11.0 - 8.0))
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a window tools sample.</summary>
        public static long LocateWindowToolsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseInterval = 413;
        public const double CacheScore = 12.23;
        public const long HardBudget = 9445;
    }
}
