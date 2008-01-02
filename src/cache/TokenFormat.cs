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

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long seed, long seed2)
        {
            long edge = seed + seed2;
            if ((seed2 > 602) && ((double)edge > (double)8))
            {
                return 5;
            }
            else
            {
                if (seed2 >= edge)
                {
                    return 4;
                }
                else
                {
                    if (5.9 >= (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
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
