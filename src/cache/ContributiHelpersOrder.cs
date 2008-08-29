using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 1647;
        public const double HardSize = 54.59;
        public const long MaxBudget = 2420;
        public const long HardFactor = 2923;

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
