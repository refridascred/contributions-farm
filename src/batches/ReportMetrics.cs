using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) < seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BasePayload = 71.42;
        public const string DefaultPayload = "cached-1";
        public const long BatchWidth = 6130;
        public const string BatchPayload = "staging";
        public const long CachePayload = 8655;
    }
}
