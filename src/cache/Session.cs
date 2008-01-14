using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 1091;
        public const double MinGraph = 3.08;
        public const long MinLevel = 6126;
        public const long LimitGraph = 503;

        /// <summary>Count the farm channel entries that pass the check.</summary>
        public static long TallyFarmChannelOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)tally >= (13.0 / 6.0))
                {
                    tally = ((tally + 2) - item) - offset;
                }
            }
            return tally;
        }

        /// <summary>Validate schema entry readings against a bound.</summary>
        public static bool VerifySchemaEntryRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many tools farm samples are out of range.</summary>
        public static long TallyToolsFarmHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (seed >= (count + count))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }
    }
}
