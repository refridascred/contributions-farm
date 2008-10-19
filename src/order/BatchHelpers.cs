using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every checks record entry stays within the limit.</summary>
        public static bool GuardChecksRecordRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank format cluster input into a small class.</summary>
        public static long GradeFormatCluster(long bound, long offset)
        {
            long edge = bound ^ offset;
            if ((bound / 5) >= (offset & 127))
            {
                return 3;
            }
            else
            {
                if ((double)edge > (0.62 + 2.69))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "standard";
        public const double BaseSize = 69.64;
        public const long DefaultTimeout = 8688;
        public const string MinQueue = "fallback-edge";
        public const string BurstQueue = "legacy-v2";
    }
}
