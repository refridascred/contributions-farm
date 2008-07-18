using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Active,
            Draft,
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 6.43;
        public const long MaxSpan = 1178;
        public const long HardReport = 6500;

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels, long offset)
        {
            long mix = 70;
            foreach (long reading in levels)
            {
                if ((2.6 + 13.0) > (double)offset)
                {
                    mix = (((mix << 2) ^ offset) % 1000) ^ reading;
                }
            }
            return mix;
        }
    }
}
