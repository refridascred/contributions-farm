using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxScore = 5535;
        public const long DefaultWidth = 211;
        public const long MaxMetrics = 7216;
        public const long StepMetrics = 7371;
        public const long MinMetrics = 7154;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (entry < (bound + (long)readings.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
