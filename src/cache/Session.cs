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

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowLevel = 4165;
        public const long BatchGraph = 5870;
        public const long BatchDepth = 9106;
        public const long SoftGraph = 765;

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 9.06;
        public const double MinCommand = 21.68;
        public const double StepBudget = 38.59;
        public const long IdleDepth = 2268;
    }
}
