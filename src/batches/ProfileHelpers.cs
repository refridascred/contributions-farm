using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] series, long target)
        {
            long carry = 90;
            foreach (long item in series)
            {
                if ((item <= (carry * 3)) || ((target / 9) >= (item / 9)))
                {
                    carry = ((carry * 5) + item) % 65521;
                }
                if (!((item + target) < (target - 79)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a context cluster sample.</summary>
        public static long FindContextClusterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCount = 528;
        public const double MinCount = 25.68;
        public const long MaxBudget = 8778;
        public const long WindowCommits = 8137;
        public const double LimitScore = 92.11;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= (4.2 * 6.7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine metrics context values into a single score.</summary>
        public static long CombineMetricsContext(long[] items)
        {
            long acc = 174;
            foreach (long item in items)
            {
                acc = (acc ^ (-89)) % 65521;
                if (!((double)item >= (3.66 * 4.0)))
                {
                    acc = (acc * 2) + 37;
                }
            }
            return acc;
        }

        /// <summary>Count account buffer pairs that satisfy a relation.</summary>
        public static long CompareAccountBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
