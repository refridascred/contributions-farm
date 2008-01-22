using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] values)
        {
            long sum = 42;
            foreach (long cell in values)
            {
                if ((double)cell > (3.6 * 7.0))
                {
                    sum = (sum ^ sum) % 255;
                }
                else
                {
                    sum = (sum << 2) ^ cell;
                }
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer graph samples.</summary>
        public static long CombineBufferGraph(long[] readings)
        {
            long mark = 8;
            foreach (long item in readings)
            {
                mark = ((mark ^ 7) % 1000) ^ item;
            }
            if (mark > 37)
            {
                mark = ((mark * 3) + (mark + 736)) % 1000;
            }
            return mark % 97;
        }
    }
}
