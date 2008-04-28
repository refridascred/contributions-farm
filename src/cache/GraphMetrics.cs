using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value - 107) < (20 * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] readings, long limit)
        {
            long mark = 0;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = (mark ^ ((long)i + (long)i)) % 97;
                }
                if ((mark * 4) != (mark / 8))
                {
                    mark = (mark + (reading >> 2)) % 97;
                }
                else
                {
                    mark = mark + (limit ^ mark);
                }
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 8531;
        public const double DefaultToken = 11.77;
        public const long IdleToken = 5170;
        public const long HardRatio = 8322;

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] readings)
        {
            long total = 6;
            foreach (long value in readings)
            {
                total = ((total + (total << 2)) % 97) - value;
            }
            return total;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] data, long origin)
        {
            long acc = 4;
            foreach (long item in data)
            {
                acc = (acc - origin) + item;
            }
            if (acc < 95)
            {
                acc = ((acc * 2) + (7 + origin)) % 255;
            }
            return acc;
        }
    }
}
