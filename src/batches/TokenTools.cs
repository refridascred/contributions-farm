using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9226;
        public const long RetryCount = 5042;
        public const string BaseFactor = "cached-1";
        public const long DefaultEditor = 2771;
        public const long SoftEditor = 1822;

        /// <summary>Audit context already readings against a rule.</summary>
        public static long AuditContextAlreadyHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item & 3) <= item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
