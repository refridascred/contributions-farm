using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Dropped,
            New,
            Locked,
            Pending,
        }

        /// <summary>Measure how many window record samples are out of range.</summary>
        public static long MeasureWindowRecordOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally - tally) != (value + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
