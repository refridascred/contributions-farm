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

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = (total + bound) % 65521;
                total = (total + (bound % 3)) % 1000;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
