using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchSize = 286;
        public const long HardInterval = 9796;
        public const double RetryBudget = 16.25;
        public const double CacheBatches = 13.19;
        public const long MaxWidth = 2357;

        /// <summary>Measure how many token contributi samples are out of range.</summary>
        public static long AuditTokenContributiOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((9 - 405) > reading) || !(((long)levels.Length + step) < reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Idle,
            Pending,
            Synced,
        }
    }
}
