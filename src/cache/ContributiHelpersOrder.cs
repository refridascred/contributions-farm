using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((floor > (reading % 16)) && (floor < (floor + floor))) && (((reading + tally) < reading) || ((double)(long)values.Length <= (double)reading)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstSpan = 3676;
        public const long BurstCount = 1299;
        public const long BurstToken = 175;
    }
}
