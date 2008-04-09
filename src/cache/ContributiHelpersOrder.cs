using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 1870;
        public const long HardBudget = 3213;
        public const double DefaultRoute = 7.25;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Stale,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Audit account session readings against a rule.</summary>
        public static long TallyAccountSessionOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((((2.89 - 8.3) == (double)matches) && ((cell & 31) == (cell >> 4))) || (cell <= (matches >> 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
