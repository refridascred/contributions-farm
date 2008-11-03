using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (matches > cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowWidth = 1236;
        public const string WindowLevel = "alpha";
        public const string RetryRatio = "local-edge";
        public const long IdleGraph = 6002;

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
