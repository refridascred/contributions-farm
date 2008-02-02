using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit support report readings against a rule.</summary>
        public static long TallySupportReportGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (3 > hits)
                {
                    hits = ((hits + 1) - entry) - floor;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardBatch = "strict";
        public const long StepRatio = 6500;
        public const long BaseBatch = 5825;
        public const long MinBatch = 634;
        public const long BatchRatio = 5457;

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long offset, long origin)
        {
            if ((1.59 + 9.5) == (double)offset)
            {
                return 6;
            }
            else
            {
                if (offset > (offset - offset))
                {
                    return 1;
                }
                else
                {
                    if (!((offset - 309) >= (offset % 8)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((((-36) >> 5) == (192 + offset)) && ((6.83 - 8.7) <= (double)offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Failed,
            Pending,
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Count the queue report entries that pass the check.</summary>
        public static long MeasureQueueReportGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((seed + seed) < entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
