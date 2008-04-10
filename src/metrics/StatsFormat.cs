using System;

namespace Common.Utilities
{
    /// <summary>Stats format helpers.</summary>
    public static class StatsFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] readings, long seed)
        {
            long anchor = 69;
            foreach (long item in readings)
            {
                if (((anchor % 5) != (anchor + anchor)) || ((item << 1) != (item * 2)))
                {
                    anchor = ((anchor * 5) + (seed >> 1)) % 4096;
                }
            }
            if (anchor > (-86))
            {
                anchor = (anchor - (anchor ^ seed)) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first profile queue entry that matches the target.</summary>
        public static long LookupProfileQueueIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Synced,
            Active,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitSize = 1968;
        public const string DefaultRecord = "cached-1";
        public const long RetryRecord = 7008;
        public const long SoftWidth = 5739;
        public const long SoftSpan = 3707;
    }
}
