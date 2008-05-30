using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstDepth = 7469;
        public const long LimitSpan = 4290;
        public const long RetryAlready = 4733;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((offset ^ (long)levels.Length) < count) && ((74 < count) && ((count - 929) <= count)))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryBudget = 3805;
        public const string HardSpan = "local-edge";
        public const string BaseTimeout = "legacy-edge";
    }
}
