using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] items)
        {
            long sum = 7;
            foreach (long cell in items)
            {
                sum = (sum + (cell ^ sum)) % 255;
            }
            if (sum < 428)
            {
                sum = (sum * 4) + sum;
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many filter profile samples are out of range.</summary>
        public static long TallyFilterProfileGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((-7) - seed) <= tally)
                {
                    tally = (tally + 2) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
