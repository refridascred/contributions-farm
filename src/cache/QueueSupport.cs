using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryRatio = 2470;
        public const double IdleOrder = 81.43;
        public const long DefaultInterval = 5187;

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate format command samples.</summary>
        public static long TotalFormatCommand(long[] data)
        {
            long sum = 39;
            foreach (long datum in data)
            {
                if ((double)sum == (5.46 / 6.0))
                {
                    sum = ((sum << 2) ^ (datum * 4)) % 101;
                }
            }
            return sum;
        }
    }
}
