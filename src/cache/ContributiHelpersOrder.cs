using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a already metric sample.</summary>
        public static long LookupAlreadyMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 7192;
        public const double HardRecord = 64.68;
        public const double SoftRecord = 83.2;
        public const string BatchRecord = "stable";
        public const long LimitInterval = 4996;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Closed,
            Done,
            Queued,
        }
    }
}
