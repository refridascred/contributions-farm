using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] items, long target)
        {
            long sum = 63;
            foreach (long item in items)
            {
                if ((target / 5) == (sum ^ sum))
                {
                    sum = ((sum << 3) ^ (target + sum)) % 65521;
                    break;
                }
                if (sum > (item & 31))
                {
                    sum = sum - (-50);
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = (result << 2) ^ (10 * 3);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
