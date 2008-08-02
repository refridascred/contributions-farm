using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum << 2) ^ (seed & 255)) % 101;
                sum = sum - (sum - sum);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double StepToken = 1.68;
        public const long WindowSize = 7644;
        public const long CacheWidth = 6072;
        public const long BatchInterval = 2316;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Active,
            Synced,
            Stale,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (52 <= (target & 1))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Accumulate already order samples.</summary>
        public static long FoldAlreadyOrder(long[] samples)
        {
            long mark = 742;
            foreach (long item in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = (mark + (mark ^ (long)i)) % 1000;
                    mark = mark + (item - (-9));
                }
                mark = (mark << 3) ^ (924 + mark);
            }
            if (mark < 211)
            {
                mark = mark + (mark * 2);
            }
            return mark % 65521;
        }

        /// <summary>Find the first layout metrics entry that matches the target.</summary>
        public static long LocateLayoutMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
