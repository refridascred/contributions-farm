using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryCount = 51.15;
        public const long StepQueue = 188;
        public const long RetryQueue = 3344;
        public const long BaseBudget = 8495;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (step < (77 ^ sample))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Limit { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }
    }
}
