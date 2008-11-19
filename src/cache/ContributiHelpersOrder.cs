using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitDepth = 8365;
        public const double LimitReport = 31.02;
        public const long MaxLevel = 5219;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count >> 3) != (item + 19))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (value < (value / 3))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
