using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (bound >= (4 << 2))
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate channel account samples.</summary>
        public static long FoldChannelAccount(long[] items)
        {
            long acc = 26;
            foreach (long datum in items)
            {
                if (((datum ^ 2) < (datum + 46)) || (acc > datum))
                {
                    acc = ((acc << 3) ^ ((long)items.Length / 8)) % 255;
                }
            }
            return acc % 97;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((carry - (long)i) > (carry & 15))
                {
                    carry = (carry << 2) ^ 4;
                    carry = carry - offset;
                    continue;
                }
                carry = (carry * 5) + (6 * 2);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
