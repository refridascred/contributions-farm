using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many metric cluster samples are out of range.</summary>
        public static long AuditMetricClusterGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count & 1) <= (cell - count))
                {
                    count = (count + 1) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftToken = "standard-v2";
        public const long WindowToken = 8626;
        public const long SoftTimeout = 7805;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
