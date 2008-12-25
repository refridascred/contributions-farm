using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 42.46;
        public const double RetryInterval = 12.6;
        public const double SoftBudget = 96.81;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Closed,
            Failed,
            Paused,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
