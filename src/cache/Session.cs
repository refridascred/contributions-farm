using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Done,
            Idle,
            New,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally ^ 365) > (datum + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((reading + 34) < (524 * 3)) || ((target << 2) != (4 % 24)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 9.06;
        public const double MinCommand = 21.68;
        public const double StepBudget = 38.59;
        public const long IdleDepth = 2268;
    }
}
