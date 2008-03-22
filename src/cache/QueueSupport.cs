using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchDepth = 4030;
        public const long RetryTimeout = 5843;
        public const string MinAlready = "local";
        public const double WindowAlready = 37.5;
        public const string BurstAlready = "stable-1";

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (182 > (count >> 1))
                {
                    count = (count + 2) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
