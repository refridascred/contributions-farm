using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(((double)datum != (7.2 / 3.0)) || ((datum << 1) < (datum ^ datum))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 14.18;
        public const long WindowTools = 752;
        public const long IdleScore = 542;
        public const double RetryTools = 68.51;
        public const long DefaultDepth = 8582;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstInterval = "cached";
        public const long BaseChecks = 3909;
        public const long StepChecks = 6128;
        public const long WindowInterval = 241;
        public const double SoftChecks = 19.31;
    }
}
