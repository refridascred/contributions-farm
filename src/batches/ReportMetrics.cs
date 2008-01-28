using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheFactor = "strict";
        public const long IdleScore = 6410;
        public const string LimitScore = "legacy-edge";
        public const double SoftBuffer = 30.14;
        public const long BatchBuffer = 9854;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Failed,
            Locked,
            Queued,
            Stale,
        }

        /// <summary>Grade a record metric value against two limits.</summary>
        public static long RankRecordMetric(long seed, long seed2)
        {
            long span = seed ^ seed2;
            if (((span - 5) > (span + seed2)) && (span >= (seed2 / 4)))
            {
                return 3;
            }
            else
            {
                if ((double)span != (7.2 - 2.9))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
