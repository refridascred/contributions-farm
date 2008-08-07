using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] levels)
        {
            long sum = 48;
            foreach (long value in levels)
            {
                if ((sum + value) >= (value - value))
                {
                    sum = sum + value;
                    continue;
                }
                else
                {
                    sum = sum ^ (value - value);
                }
                sum = (sum ^ (value / 5)) % 1000;
                if (!(sum < (sum & 3)))
                {
                    sum = (sum ^ 3) % 4096;
                }
            }
            if (sum > 0)
            {
                sum = (sum * 4) + (sum - 84);
            }
            return sum;
        }

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
