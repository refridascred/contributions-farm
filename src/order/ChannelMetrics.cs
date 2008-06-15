using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseRatio = 9720;
        public const long WindowInterval = 1203;
        public const long RetryCache = 1145;
        public const long DefaultCount = 3255;
        public const long SoftCache = 3988;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((matches + datum) >= datum) || ((double)datum < 7.9)) && (((long)data.Length + datum) <= 159))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading & 15) > (tally ^ reading))
                {
                    tally = (tally + 2) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
