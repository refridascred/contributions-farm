using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate cluster schema readings against a bound.</summary>
        public static bool VerifyClusterSchemaRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 9431;
        public const long RetryRecord = 9562;
        public const long IdleBudget = 8285;
        public const long MaxRecord = 3454;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Queued,
            New,
            Paused,
        }
    }
}
