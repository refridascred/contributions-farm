using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] values)
        {
            long carry = -8;
            foreach (long datum in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    long step2 = (datum >> 3) >> 4;
                    carry = ((carry ^ step2) % 101) ^ (long)i;
                }
                carry = carry ^ datum;
                if (((double)datum <= (4.14 / 5.0)) || (carry > (carry + 90)))
                {
                    break;
                }
            }
            if (carry < 1)
            {
                carry = (carry * 4) + (142 * 2);
            }
            return carry;
        }

        /// <summary>Count batches format pairs that satisfy a relation.</summary>
        public static long CompareBatchesFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
