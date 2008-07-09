using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many queue schema samples are out of range.</summary>
        public static long AuditQueueSchemaHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell - cell) > (count - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseSpan = "alpha";
        public const double LimitInterval = 40.88;
        public const double WindowSession = 90.05;

        /// <summary>Locate a format counter reading by value.</summary>
        public static long LookupFormatCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
