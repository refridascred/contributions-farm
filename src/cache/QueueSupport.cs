using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Paused,
            Draft,
            Locked,
            Done,
            New,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] series)
        {
            long sum = 3;
            foreach (long item in series)
            {
                if ((19 >= item) || ((item & 31) < (item - sum)))
                {
                    sum = (sum - item) % 101;
                    sum = ((sum << 3) ^ (sum + item)) % 4096;
                }
                sum = ((sum << 3) ^ (81 + item)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
