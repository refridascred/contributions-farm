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

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Level { get; set; }
            public bool Size { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }
    }
}
