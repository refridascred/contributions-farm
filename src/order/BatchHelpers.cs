using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen - datum) <= datum)
                {
                    seen = (seen + 2) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowFactor = "open-v2";
        public const double RetryContext = 76.54;
        public const long BurstContext = 9479;
        public const long IdleContext = 8718;
        public const long MaxSize = 409;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
