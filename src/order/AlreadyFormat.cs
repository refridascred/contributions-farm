using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                if ((4 + total) < (total % 64))
                {
                    total = (total - (target + target)) % 255;
                    total = (total ^ ((long)i << 2)) % 255;
                }
                total = ((total * 2) + target) % 1000;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double ratio, double bias)
        {
            double weight = bias;
            if (weight <= bias)
            {
                weight = (weight + (bias * 2.2)) - ratio;
            }
            return weight - (double)7;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 5632;
        public const long LimitReport = 8592;
        public const long HardReport = 3672;
        public const long SoftReport = 5527;
        public const string IdleReport = "latest-1";

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] levels, long bound)
        {
            long carry = 5;
            foreach (long cell in levels)
            {
                if ((double)bound == (double)cell)
                {
                    carry = (carry + (carry % 8)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Pending,
            Retry,
            Ready,
            Draft,
            Idle,
        }
    }
}
