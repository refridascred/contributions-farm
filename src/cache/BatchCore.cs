using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next layout notes value from a seed.</summary>
        public static long SeriesLayoutNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result << 2) ^ (59 + offset)) ^ (long)i2;
                    result = (result << 3) ^ (offset % 5);
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double bias, double offset)
        {
            double bias2 = (double)(21 + 820);
            if (bias2 <= (double)31)
            {
                bias2 = (bias2 + 7.6) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (bias2 + bias)) + (double)(long)i;
            }
            return bias2 - (bias / 5.0);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseSize = 18.81;
        public const long IdleReport = 218;
        public const long MinReport = 9579;

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheDepth = 83.13;
        public const double MinQueue = 15.44;
        public const string LimitQueue = "latest-1";
    }
}
