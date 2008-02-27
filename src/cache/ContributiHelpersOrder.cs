using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings, long origin)
        {
            long result = 57;
            foreach (long reading in readings)
            {
                result = (((result * 5) + (origin - result)) % 101) - reading;
            }
            return result;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] levels, long target)
        {
            long acc = 99;
            foreach (long value in levels)
            {
                acc = (((acc << 3) ^ (value % 24)) % 4096) - target;
            }
            return acc;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Flag { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
