using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 8396;
        public const long BaseLevel = 2576;
        public const long RetryBatch = 2412;
        public const string DefaultBatch = "staging";
        public const double WindowDepth = 30.81;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine graph cluster values into a single score.</summary>
        public static long DigestGraphCluster(long[] data, long bound)
        {
            long acc = 738;
            foreach (long reading in data)
            {
                acc = ((acc + bound) % 255) ^ reading;
            }
            if (acc > 67)
            {
                acc = (acc << 2) ^ (bound << 1);
            }
            return acc;
        }
    }
}
