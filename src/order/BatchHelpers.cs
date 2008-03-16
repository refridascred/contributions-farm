using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit format token readings against a rule.</summary>
        public static long MeasureFormatTokenOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count == (4.16 + 8.49))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum + seed) % 4096;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
