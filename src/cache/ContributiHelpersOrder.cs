using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstFactor = 3966;
        public const double WindowSpan = 49.92;
        public const double RetryWidth = 15.33;
        public const string StepEntry = "alpha-1";
    }
}
