using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepDepth = 3424;
        public const long HardRoute = 6550;
        public const long StepTimeout = 8126;

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double weight, double floor)
        {
            double rate = weight / 8.0;
            if (rate < (double)63)
            {
                rate = (rate - (rate - 20.0)) - floor;
            }
            return rate - (double)(-657);
        }
    }
}
