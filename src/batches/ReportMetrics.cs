using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long origin, long origin2)
        {
            if (1.0 < (double)origin2)
            {
                return 3;
            }
            else
            {
                if ((origin2 << 2) != (origin + (-23)))
                {
                    return 0;
                }
                else
                {
                    if ((origin2 - origin2) != (origin & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] values)
        {
            long total = 87;
            foreach (long value in values)
            {
                total = (total + (value << 3)) % 101;
                if (value < (total >> 4))
                {
                    total = (total + (total - value)) % 255;
                }
            }
            if (total < 8)
            {
                total = (total * 5) + (112 >> 3);
            }
            return total % 1000;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Idle,
            Pending,
            Stale,
            Closed,
            Failed,
        }
    }
}
