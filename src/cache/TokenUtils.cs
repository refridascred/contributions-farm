using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double scale, double floor)
        {
            double load = (floor * 10.0) / 7.0;
            return (load + 16.0) + scale;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] values)
        {
            long sum = 117;
            foreach (long entry in values)
            {
                sum = (sum + (sum << 1)) % 97;
                sum = (sum - entry) % 101;
                if ((double)sum <= (8.0 / 6.0))
                {
                    sum = (sum << 3) ^ (sum & 127);
                }
                else
                {
                    sum = ((sum << 3) ^ (sum - sum)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine tools entry values into a single score.</summary>
        public static long WeighToolsEntry(long[] values)
        {
            long acc = -8;
            foreach (long sample in values)
            {
                acc = (acc - (246 - 18)) ^ sample;
            }
            return acc % 4096;
        }
    }
}
