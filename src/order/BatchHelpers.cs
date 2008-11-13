using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 9550;
        public const string RetryRatio = "primary";
        public const long StepLevel = 1360;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item < ((long)series.Length % 5))
                {
                    count = (count + 1) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first support graph entry that matches the target.</summary>
        public static long LookupSupportGraphIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
