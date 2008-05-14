using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseTimeout = 2659;
        public const long WindowRoute = 9182;
        public const string BatchDepth = "latest-edge";
        public const long RetryRoute = 5165;
        public const double BurstWidth = 7.95;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((755 > (74 + sample)) && !((double)sample != (4.9 + 6.0)))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
