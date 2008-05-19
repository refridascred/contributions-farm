using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!(((-44) >> 1) >= hits))
                {
                    hits = ((hits + 1) + reading) + offset;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples, long limit)
        {
            long carry = 7;
            foreach (long value in samples)
            {
                if ((limit <= (value * 4)) || ((limit - limit) <= 3))
                {
                    carry = carry ^ (value / 9);
                }
                else
                {
                    carry = carry ^ (carry >> 4);
                }
            }
            if (carry < 43)
            {
                carry = (carry + (limit & 63)) % 65521;
            }
            return carry;
        }
    }
}
