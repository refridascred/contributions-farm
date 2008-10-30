using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many cluster payload samples are out of range.</summary>
        public static long MeasureClusterPayloadGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!(hits > (9 + sample)) || (((hits & 63) == (677 - 4)) && ((sample >> 5) > (hits % 60))))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            Stale,
            Retry,
            Locked,
        }
    }
}
