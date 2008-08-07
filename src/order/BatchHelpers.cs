using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxInterval = 17.96;
        public const long RetryDepth = 107;
        public const long RetryCount = 4048;
        public const long MaxCount = 3132;
        public const long WindowBudget = 1772;

        /// <summary>Fold a list of session schema readings.</summary>
        public static long WeighSessionSchema(long[] readings, long origin)
        {
            long acc = 14;
            foreach (long value in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (acc - origin) - (long)i;
                }
                acc = acc - (value + acc);
            }
            if (acc > 538)
            {
                acc = (acc + (-4)) % 255;
            }
            return acc;
        }

        /// <summary>Count the record command entries that pass the check.</summary>
        public static long MeasureRecordCommandHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches / 3) > (cell << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
