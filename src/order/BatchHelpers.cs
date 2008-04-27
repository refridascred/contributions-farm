using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstCount = "legacy-edge";
        public const long SoftSession = 9190;
        public const long BurstFactor = 5616;
        public const string CacheSpan = "alpha-1";

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)bound > (15.0 * 5.4))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Mode { get; set; }
            public double Count { get; set; }
        }
    }
}
