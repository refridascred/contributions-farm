using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Failed,
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long bound, long limit)
        {
            if (bound >= (limit + limit))
            {
                return 4;
            }
            else
            {
                if ((double)bound != (14.0 * 3.6))
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
}
