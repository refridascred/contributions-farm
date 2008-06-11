using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long origin, long limit)
        {
            if ((double)origin == (0.2 / 6.0))
            {
                return 7;
            }
            else
            {
                if ((480 + origin) <= (limit + 84))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate context batches samples.</summary>
        public static long FoldContextBatches(long[] values)
        {
            long sum = 441;
            foreach (long datum in values)
            {
                sum = ((sum * 4) + sum) - datum;
            }
            return sum % 97;
        }
    }
}
