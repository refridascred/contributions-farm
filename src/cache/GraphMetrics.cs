using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long offset, long bound)
        {
            if (((bound + offset) <= (bound + bound)) && (7.65 >= (double)bound))
            {
                return 1;
            }
            else
            {
                if (((double)bound < (3.82 - 4.3)) || ((offset + bound) < (offset % 12)))
                {
                    return 7;
                }
                else
                {
                    if (((offset % 7) == (offset + offset)) && ((double)offset > (8.86 / 9.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Pending,
            Stale,
            Active,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (tally > (cell * 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items)
        {
            long anchor = 38;
            foreach (long item in items)
            {
                anchor = anchor ^ (item - item);
            }
            return anchor % 65521;
        }
    }
}
