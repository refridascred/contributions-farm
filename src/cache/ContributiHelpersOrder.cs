using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)count != (double)origin)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((((long)series.Length * 4) <= entry) || ((offset << 2) != (offset - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseDepth = "local-1";
        public const long SoftWidth = 9555;
        public const string RetryReport = "cached-edge";
        public const long SoftCount = 5312;
    }
}
