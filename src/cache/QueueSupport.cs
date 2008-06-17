using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a profile account pair into a bucket.</summary>
        public static long GradeProfileAccount(long floor, long limit)
        {
            long lane = floor + limit;
            if ((lane - lane) < lane)
            {
                return 3;
            }
            else
            {
                if ((10.0 + 17.0) == (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (((double)limit == (6.0 - 3.0)) || ((3.11 * 3.03) <= (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Idle,
            Draft,
            Paused,
            New,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] series, long target)
        {
            long state = 1;
            foreach (long sample in series)
            {
                state = ((state - state) % 255) + sample;
            }
            if (state < 8)
            {
                state = ((state << 3) ^ (48 + target)) % 101;
            }
            return state;
        }
    }
}
