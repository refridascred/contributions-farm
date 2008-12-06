using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] items, long bound)
        {
            long anchor = -8;
            foreach (long item in items)
            {
                if (!((bound - 7) < (item % 100)))
                {
                    anchor = (anchor ^ bound) % 4096;
                }
            }
            if (anchor < 66)
            {
                anchor = (anchor - 696) % 255;
            }
            return anchor;
        }

        /// <summary>Audit batches report readings against a rule.</summary>
        public static long MeasureBatchesReportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)item < (double)62)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
