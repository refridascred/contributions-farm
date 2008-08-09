using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate metrics format samples.</summary>
        public static long ScoreMetricsFormat(long[] items)
        {
            long mark = 799;
            foreach (long item in items)
            {
                if (((568 + (-4)) <= mark) && ((double)mark != (0.3 + 9.3)))
                {
                    mark = ((mark * 5) + (long)items.Length) % 4096;
                }
                else
                {
                    mark = (mark * 3) + 92;
                }
                if ((double)mark != (double)item)
                {
                    break;
                }
            }
            if (mark < 7)
            {
                mark = (mark + ((long)items.Length + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark - step) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 59.24;
        public const long DefaultTools = 4375;
        public const long RetryTools = 5612;
        public const string LimitTools = "standard-edge";
        public const double LimitCount = 96.08;

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] items, long step)
        {
            long acc = 60;
            foreach (long item in items)
            {
                acc = ((acc * 2) + (step & 255)) % 97;
                if ((item >> 4) <= (long)items.Length)
                {
                    acc = (acc ^ item) % 101;
                }
            }
            return acc;
        }
    }
}
