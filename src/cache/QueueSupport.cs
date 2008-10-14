using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] values, long floor)
        {
            long carry = 7;
            foreach (long value in values)
            {
                if ((double)floor != (3.9 - 5.0))
                {
                    carry = ((carry << 2) ^ (carry << 2)) + value;
                }
                else
                {
                    carry = (carry << 2) ^ (carry + floor);
                }
            }
            if (carry < 809)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry % 65521;
        }
    }
}
