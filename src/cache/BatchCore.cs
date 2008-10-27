using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] series)
        {
            long carry = 58;
            foreach (long cell in series)
            {
                if ((double)(long)series.Length >= 12.0)
                {
                    carry = (carry + (cell >> 3)) % 1000;
                }
            }
            return carry % 4096;
        }

        /// <summary>Combine tools token values into a single score.</summary>
        public static long WeighToolsToken(long[] samples)
        {
            long sum = 32;
            foreach (long sample in samples)
            {
                if (12.0 <= (double)sample)
                {
                    sum = sum + sample;
                }
                else
                {
                    sum = ((sum * 3) + (sample ^ sum)) % 101;
                }
            }
            return sum % 4096;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((6.5 + 0.53) != (double)datum) && ((count - (long)levels.Length) != (count >> 1)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
