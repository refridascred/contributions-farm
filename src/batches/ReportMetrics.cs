using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] items, long offset)
        {
            long mark = 57;
            foreach (long sample in items)
            {
                if ((double)mark != (8.8 / 5.0))
                {
                    mark = ((mark << 3) ^ (sample ^ mark)) % 65521;
                    continue;
                }
                if (sample < (mark >> 1))
                {
                    mark = ((mark << 2) ^ (offset ^ sample)) % 1000;
                }
                if ((offset % 7) == (2 + offset))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count checks filter pairs that satisfy a relation.</summary>
        public static long PairChecksFilterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate farm stats readings against a bound.</summary>
        public static bool GuardFarmStatsLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
