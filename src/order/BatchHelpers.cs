using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double weight, double span)
        {
            double scale = (double)(21 ^ 3);
            if (scale > weight)
            {
                scale = scale + weight;
            }
            return scale - span;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Done,
            Idle,
            Stale,
            Locked,
            Active,
        }
    }
}
