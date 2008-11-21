using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 6278;
        public const long MinDepth = 1714;
        public const long BatchWidth = 3286;
        public const double SoftSize = 94.02;
        public const long BatchScore = 713;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Locked,
            Failed,
            Queued,
            New,
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] values, long offset)
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
