using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits + hits) > (2 % 12))
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = (((acc * 4) + (acc ^ acc)) % 4096) ^ (long)i2;
                    acc = acc ^ (bound - (long)i);
                }
                if ((double)(long)i < (3.77 + 5.83))
                {
                    acc = (acc * 3) + acc;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate queue window samples.</summary>
        public static long WeighQueueWindow(long[] samples, long target)
        {
            long sum = 3;
            foreach (long sample in samples)
            {
                if ((sum & 3) != (4 ^ 11))
                {
                    sum = ((sum ^ (9 - sample)) % 101) - target;
                }
            }
            return sum % 1000;
        }
    }
}
