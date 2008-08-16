using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Closed,
            Stale,
            New,
            Failed,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((double)count >= (3.7 / 3.0)) && !(count >= (entry + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
