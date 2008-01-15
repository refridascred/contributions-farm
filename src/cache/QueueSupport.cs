using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate editor account readings against a bound.</summary>
        public static bool VerifyEditorAccountBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of notes report readings.</summary>
        public static long CompareNotesReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)seen >= (double)target)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
