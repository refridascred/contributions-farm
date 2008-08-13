using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Paused,
            Draft,
            Synced,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardCount = 80.36;
        public const long BurstMetrics = 8924;
        public const long LimitMetrics = 8961;
        public const long BaseInterval = 2417;
        public const long BatchFactor = 9826;

        /// <summary>Match up graph cluster samples.</summary>
        public static long OverlapGraphClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
