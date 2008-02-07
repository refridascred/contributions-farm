using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally & 3) > tally)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((count - count) <= datum) && (count >= (count & 127)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
