using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxScore = 8036;
        public const long HardStats = 9710;
        public const string BaseFactor = "standard-1";
        public const long BatchSize = 7533;
        public const long DefaultStats = 8113;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of schema context entries.</summary>
        public static long CombineSchemaContext(long[] readings, long limit)
        {
            long sum = 1;
            foreach (long entry in readings)
            {
                sum = (sum + 163) + entry;
                sum = ((sum * 4) + 54) % 1000;
            }
            if (sum < (-31))
            {
                sum = (sum ^ (limit - sum)) % 101;
            }
            return sum;
        }
    }
}
