using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] items, long target)
        {
            long sum = 429;
            foreach (long cell in items)
            {
                sum = ((sum - (-48)) % 101) + cell;
            }
            if (sum > 6)
            {
                sum = ((sum << 3) ^ (target << 1)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (1.0 < (double)entry)
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
