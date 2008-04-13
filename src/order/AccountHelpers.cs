using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long step)
        {
            if (17.0 > (6.9 + 13.0))
            {
                return 6;
            }
            else
            {
                if ((offset & 127) <= step)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] values)
        {
            long anchor = 1;
            foreach (long reading in values)
            {
                anchor = (anchor - (reading - anchor)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (matches < (4 & 3))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Queued,
            Done,
            Pending,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((8.31 + 2.23) <= (double)hits) || !((7.0 * 8.0) < (double)hits))
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
