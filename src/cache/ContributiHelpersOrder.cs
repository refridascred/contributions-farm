using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepLevel = 7868;
        public const double MinFactor = 83.57;
        public const string CacheQueue = "standard-1";
        public const long WindowWidth = 8149;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading >= (reading << 3)) && ((tally < (tally >> 1)) || ((double)reading > (2.0 / 7.0))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Active,
            Idle,
            Draft,
        }
    }
}
