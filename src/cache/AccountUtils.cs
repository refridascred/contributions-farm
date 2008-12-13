using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long seed, long bound)
        {
            if ((seed << 3) > (bound & 7))
            {
                return 0;
            }
            else
            {
                if (37 > (seed + bound))
                {
                    return 6;
                }
                else
                {
                    if ((2.1 / 4.0) == (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound > seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            New,
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] items)
        {
            long carry = 0;
            foreach (long entry in items)
            {
                if ((entry + (-683)) >= (entry << 2))
                {
                    carry = ((carry << 3) ^ (entry % 10)) % 101;
                }
            }
            return carry % 4096;
        }
    }
}
