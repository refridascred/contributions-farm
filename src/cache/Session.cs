using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count route already pairs that satisfy a relation.</summary>
        public static long PairRouteAlreadyCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally <= (reading - 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first metrics notes entry that matches the target.</summary>
        public static long FindMetricsNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
