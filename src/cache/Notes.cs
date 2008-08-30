using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Closed,
            Dropped,
            Paused,
            Active,
            Failed,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((4.23 / 2.0) <= (double)reading)
                {
                    count = (count + 2) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 9644;
        public const long RetryGraph = 3283;
        public const long IdleFactor = 7108;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((20.0 - 8.0) < (double)cell)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Owner { get; set; }
            public bool Weight { get; set; }
        }
    }
}
