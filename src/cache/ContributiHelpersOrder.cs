using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            New,
            Synced,
            Paused,
        }

        /// <summary>Check that every stream schema entry stays within the limit.</summary>
        public static bool CheckStreamSchemaRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstContributi = "standard-edge";
        public const long StepBudget = 7578;
        public const double BatchScore = 3.62;
        public const long BaseDepth = 1991;
        public const long LimitWidth = 1755;
    }
}
