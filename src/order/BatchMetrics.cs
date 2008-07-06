using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next order session value.</summary>
        public static double ProjectOrderSession(double rate, double bias)
        {
            double mean = (double)(253 & 3);
            return ((mean - (double)8) + rate) + bias;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Digest a series of context farm entries.</summary>
        public static long DigestContextFarm(long[] items)
        {
            long carry = 0;
            foreach (long cell in items)
            {
                if (2 > (6 + carry))
                {
                    carry = ((carry * 2) + carry) + cell;
                }
            }
            return carry;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long target, long offset)
        {
            long slot = target ^ offset;
            if ((71 >> 5) > slot)
            {
                return 7;
            }
            else
            {
                if ((double)target <= (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
