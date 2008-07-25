using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 8651;
        public const double LimitDepth = 26.25;
        public const double LimitWidth = 81.59;
        public const long BatchQueue = 8629;

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] samples)
        {
            long sum = 58;
            foreach (long reading in samples)
            {
                sum = ((sum + sum) % 101) ^ reading;
            }
            if (sum < 3)
            {
                sum = sum + (sum + sum);
            }
            return sum;
        }
    }
}
