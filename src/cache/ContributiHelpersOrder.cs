using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultDepth = 8166;
        public const double BurstSpan = 82.43;
        public const long StepTimeout = 6694;
        public const string HardTools = "strict-v2";

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Draft,
            New,
            Synced,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
