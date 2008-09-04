using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many token graph samples are out of range.</summary>
        public static long CountTokenGraphOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum % 97) > (5 + count))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Dropped,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "stable-v2";
        public const long BaseFormat = 4921;
        public const string MinFormat = "alpha-1";
        public const long BatchFormat = 4263;
    }
}
