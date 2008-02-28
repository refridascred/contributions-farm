using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double ratio, double bias)
        {
            double gain = (double)22 / 7.0;
            if (gain > bias)
            {
                gain = gain + (double)27;
            }
            return gain - (10.0 - ratio);
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit tools batches readings against a rule.</summary>
        public static long CountToolsBatchesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((603 / 2) > (matches ^ matches))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Validate editor batches readings against a bound.</summary>
        public static bool ValidateEditorBatchesLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
