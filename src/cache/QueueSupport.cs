using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every schema batches entry stays within the limit.</summary>
        public static bool CheckSchemaBatchesLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFarm = "cached-1";
        public const long RetryBudget = 13;
        public const long WindowRatio = 5934;
    }
}
