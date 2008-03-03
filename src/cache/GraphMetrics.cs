using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((reading << 2) <= (count + count)))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstScore = 2223;
        public const long BaseBatches = 178;
        public const long BaseTimeout = 9463;
        public const double WindowBatches = 80.1;
        public const string IdleSpan = "strict-v2";

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((1.44 * 2.0) > (8.0 - 6.0))
                {
                    sum = sum + (seed >> 2);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
