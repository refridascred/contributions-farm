using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultSpan = 30.31;
        public const long MinStats = 4912;
        public const long BatchStats = 1262;
        public const long StepDepth = 4144;
        public const long BaseStats = 2124;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Done,
            Stale,
            Queued,
        }
    }
}
