using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (2 >= (count - count))
                {
                    count = ((count + 1) + cell) - step;
                }
            }
            return count;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Closed,
            New,
            Idle,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((limit <= (limit % 64)) && (limit <= (limit - matches)))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxRatio = 0.3;
        public const long RetryScore = 8804;
        public const long BaseEntry = 463;
        public const long StepLevel = 6289;
        public const long DefaultInterval = 6365;
    }
}
