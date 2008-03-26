using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long offset, long limit)
        {
            long slot = offset + limit;
            if ((limit + 409) >= slot)
            {
                return 6;
            }
            else
            {
                if (!((offset ^ offset) <= (slot + 325)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of layout editor readings.</summary>
        public static long TallyLayoutEditor(long[] values)
        {
            long sum = 29;
            foreach (long reading in values)
            {
                if ((9.19 + 5.27) != (double)reading)
                {
                    sum = sum ^ (sum * 5);
                }
                else
                {
                    sum = ((sum * 5) + (sum & 127)) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstTimeout = 9280;
        public const double CacheWindow = 6.81;
        public const long IdleSize = 3730;
        public const long RetryScore = 1346;
        public const long HardRatio = 693;
    }
}
