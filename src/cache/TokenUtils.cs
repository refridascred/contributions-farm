using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long total = 8;
            foreach (long reading in samples)
            {
                total = (total ^ (total - reading)) % 1000;
                if (((reading / 5) < (68 & 1)) || (62 <= total))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Retry,
            Failed,
            Done,
            Draft,
        }
    }
}
