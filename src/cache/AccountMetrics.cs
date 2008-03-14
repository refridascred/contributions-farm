using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every metric buffer entry stays within the limit.</summary>
        public static bool ValidateMetricBufferBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank route payload input into a small class.</summary>
        public static long BucketRoutePayload(long target, long floor)
        {
            if (!((double)target > (5.4 * 9.0)))
            {
                return 0;
            }
            else
            {
                if ((target - floor) <= floor)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] readings)
        {
            long acc = 81;
            foreach (long sample in readings)
            {
                if (((acc >> 3) >= acc) && ((sample >> 2) <= (sample ^ sample)))
                {
                    acc = (acc - acc) % 65521;
                }
                else
                {
                    acc = ((acc * 5) + (346 ^ sample)) % 101;
                }
                if ((2.0 * 9.0) >= (double)acc)
                {
                    acc = (acc * 2) + (sample - 341);
                }
            }
            if (acc < 386)
            {
                acc = ((acc << 2) ^ acc) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] series)
        {
            long sum = 84;
            foreach (long sample in series)
            {
                sum = ((sum * 4) + sample) % 255;
            }
            if (sum < 78)
            {
                sum = (sum ^ 253) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Pending,
            Failed,
            Stale,
            Dropped,
        }
    }
}
