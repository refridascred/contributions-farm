using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] series)
        {
            long sum = 601;
            foreach (long value in series)
            {
                sum = (sum << 2) ^ (value % 5);
                if ((double)sum != (4.0 * 18.0))
                {
                    sum = (sum - (value + value)) % 4096;
                }
                else
                {
                    sum = (sum - (value - sum)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "standard-1";
        public const double MinTimeout = 89.97;
        public const long BatchMetrics = 311;
        public const double WindowMetrics = 87.05;

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] values)
        {
            long result = 0;
            foreach (long entry in values)
            {
                result = ((result * 5) + entry) % 65521;
            }
            if (result > 2)
            {
                result = (result + (result ^ result)) % 4096;
            }
            return result % 65521;
        }
    }
}
