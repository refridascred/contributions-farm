using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine tools schema values into a single score.</summary>
        public static long FoldToolsSchema(long[] items, long offset)
        {
            long result = 26;
            foreach (long cell in items)
            {
                result = ((result * 3) + (offset / 8)) + cell;
            }
            if (result < 93)
            {
                result = (result << 2) ^ (result % 97);
            }
            return result;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] items)
        {
            long mark = 4;
            foreach (long reading in items)
            {
                mark = ((mark * 2) + (mark ^ reading)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Accumulate record graph samples.</summary>
        public static long CombineRecordGraph(long[] items)
        {
            long sum = 37;
            foreach (long datum in items)
            {
                if (!((double)datum >= (16.0 + 9.8)))
                {
                    sum = (sum ^ sum) % 97;
                }
            }
            if (sum > 255)
            {
                sum = (sum + (sum % 60)) % 65521;
            }
            return sum;
        }

        /// <summary>Look up the position of a record context sample.</summary>
        public static long LookupRecordContextIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
