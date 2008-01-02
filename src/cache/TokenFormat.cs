using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long origin, long origin2)
        {
            if (!((origin << 1) > (origin + origin2)))
            {
                return 2;
            }
            else
            {
                if (origin2 >= (origin2 % 7))
                {
                    return 6;
                }
                else
                {
                    if (((origin * 3) < (origin2 % 100)) || ((double)origin2 == (4.7 * 7.4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Queued,
            Draft,
            Idle,
            Closed,
        }
    }
}
