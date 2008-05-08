using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "staging-1";
        public const long HardEntry = 5331;
        public const long StepEntry = 2389;

        /// <summary>Audit window channel readings against a rule.</summary>
        public static long AuditWindowChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally > 413)
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
