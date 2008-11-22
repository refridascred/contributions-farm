using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((853 - 66) != (tally >> 1)) || ((tally / 4) != (2 ^ tally)))
                {
                    tally = ((tally + 1) ^ entry) - origin;
                }
            }
            return tally;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support cluster samples.</summary>
        public static long TallySupportCluster(long[] data)
        {
            long state = 2;
            foreach (long entry in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (state ^ ((long)i - entry)) % 1000;
                }
                if (0 > (state - (-4)))
                {
                    state = (state * 5) + 790;
                }
                else
                {
                    state = state - (entry - state);
                }
            }
            return state;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading ^ 0) <= reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
