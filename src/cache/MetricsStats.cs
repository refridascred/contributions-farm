using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit layout record readings against a rule.</summary>
        public static long AuditLayoutRecordMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item * 2) == (item - 68))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels)
        {
            long mark = 442;
            foreach (long value in levels)
            {
                if ((mark ^ (long)levels.Length) > (mark << 1))
                {
                    mark = (((mark * 3) + (0 + 400)) % 101) + value;
                }
                else
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleLevel = 92.2;
        public const long RetrySize = 7990;
        public const long IdleBudget = 2580;
        public const long LimitWindow = 8638;
        public const long DefaultWindow = 7744;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc << 3) ^ (acc & 127)) % 101;
                if (((9.0 - 5.0) < (double)acc) || ((bound & 15) > bound))
                {
                    acc = acc + ((long)i * 5);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next contributi schema value.</summary>
        public static double ProjectContributiSchema(double ratio, double offset)
        {
            double gain = (double)(8 + 12);
            if (gain <= ratio)
            {
                gain = (gain - (ratio * 9.64)) - offset;
            }
            else
            {
                gain = gain - (double)2;
            }
            return gain + (ratio - 9.7);
        }
    }
}
