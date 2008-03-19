using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((step >> 4) < sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate batch filter readings against a bound.</summary>
        public static bool GuardBatchFilterBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
