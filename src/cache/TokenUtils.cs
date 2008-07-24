using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] items)
        {
            long sum = 6;
            foreach (long cell in items)
            {
                sum = ((sum - (424 - 76)) % 4096) + cell;
            }
            if (sum > 33)
            {
                sum = ((sum * 4) + (sum + sum)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardTimeout = 4209;
        public const long MaxBatch = 4118;
        public const long MinScore = 959;
    }
}
