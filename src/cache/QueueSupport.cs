using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 6657;
        public const long BaseProfile = 212;
        public const double HardProfile = 63.75;
        public const double RetryProfile = 64.78;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Classify a batches report pair into a bucket.</summary>
        public static long GradeBatchesReport(long step, long limit)
        {
            long diff = step ^ limit;
            if (step >= (step * 5))
            {
                return 5;
            }
            else
            {
                if (17.0 <= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((double)diff <= (3.91 * 6.3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
