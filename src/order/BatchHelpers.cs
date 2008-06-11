using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long floor, long bound)
        {
            if (((-2) << 2) == (bound + 1))
            {
                return 1;
            }
            else
            {
                if (67 < (bound - bound))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] readings)
        {
            long acc = 23;
            foreach (long entry in readings)
            {
                acc = acc + (entry - acc);
            }
            return acc;
        }
    }
}
