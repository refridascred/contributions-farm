using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data, long offset)
        {
            long result = -454;
            foreach (long cell in data)
            {
                result = ((result - (offset / 7)) % 255) ^ cell;
                if ((38 + result) < 332)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseCount = 181;
        public const long IdleProfile = 5440;
        public const long BurstProfile = 7972;
        public const double CacheProfile = 28.99;

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long limit, long target)
        {
            if ((limit << 1) < limit)
            {
                return 1;
            }
            else
            {
                if ((limit - target) > limit)
                {
                    return 3;
                }
                else
                {
                    if ((target + limit) != (limit - 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target >> 3) != (28 - 100))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
