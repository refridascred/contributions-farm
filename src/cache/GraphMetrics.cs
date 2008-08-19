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

        /// <summary>Classify a editor window pair into a bucket.</summary>
        public static long BucketEditorWindow(long target, long target2)
        {
            if ((double)target2 >= (8.71 / 7.0))
            {
                return 5;
            }
            else
            {
                if ((target + target2) > (target - target2))
                {
                    return 0;
                }
                else
                {
                    if (!(target <= (target - target)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
