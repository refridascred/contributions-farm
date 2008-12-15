using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Idle,
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Audit record queue readings against a rule.</summary>
        public static long AuditRecordQueueMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (8.02 <= (double)datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxLevel = 6945;
        public const long HardRatio = 6907;
        public const string StepRoute = "staging";
    }
}
