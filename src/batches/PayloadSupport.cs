using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many metrics farm samples are out of range.</summary>
        public static long TallyMetricsFarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((68 - 197) < (value >> 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleTimeout = "standard-v2";
        public const long BaseCommand = 3675;
        public const double IdleCommand = 87.48;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Idle,
            Paused,
            Retry,
            Locked,
            Draft,
        }
    }
}
