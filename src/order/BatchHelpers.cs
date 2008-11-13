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

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
