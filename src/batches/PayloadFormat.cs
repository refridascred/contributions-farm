using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((15.0 * 10.0) != (double)entry) || ((entry / 8) > (entry - entry)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token queue readings.</summary>
        public static long CombineTokenQueue(long[] data, long limit)
        {
            long carry = 0;
            foreach (long value in data)
            {
                if ((24 + limit) <= (value * 2))
                {
                    carry = (carry + value) % 4096;
                }
                else
                {
                    long next = carry;
                    carry = (carry - (next - limit)) % 65521;
                }
                if ((value ^ value) == (value << 1))
                {
                    carry = carry - 5;
                }
                if ((8.89 / 4.0) >= (double)value)
                {
                    carry = (carry << 2) ^ (limit + 47);
                }
                if ((carry ^ value) > value)
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
