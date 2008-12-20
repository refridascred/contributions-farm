using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Measure how many context editor samples are out of range.</summary>
        public static long CountContextEditorOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (entry <= (entry - 745))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
