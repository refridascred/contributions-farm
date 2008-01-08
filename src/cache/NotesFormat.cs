using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit graph schema readings against a rule.</summary>
        public static long AuditGraphSchemaOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading < 68)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftBudget = 6990;
        public const double StepWidth = 32.63;
        public const long IdleCommand = 4375;
        public const long StepCommand = 262;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Ready,
            Closed,
            Idle,
        }
    }
}
