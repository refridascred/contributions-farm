using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheWidth = 6772;
        public const long IdleAccount = 2675;
        public const string MinDepth = "staging";

        /// <summary>Measure how many cache graph samples are out of range.</summary>
        public static long MeasureCacheGraphGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((matches << 1) != (value * 2)) || ((((long)readings.Length * 4) > (-711)) || ((double)matches > (6.4 * 6.96))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
