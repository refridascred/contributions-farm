using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 5460;
        public const long WindowLayout = 5105;
        public const long CacheLayout = 2805;

        /// <summary>Audit graph githubfarm readings against a rule.</summary>
        public static long AuditGraphGithubfarmGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry & 31) > floor)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
