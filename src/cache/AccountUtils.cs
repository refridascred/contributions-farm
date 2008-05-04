using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] values)
        {
            long acc = -306;
            foreach (long reading in values)
            {
                if (reading > (2 + 915))
                {
                    acc = acc + (acc ^ 148);
                }
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of filter counter entries.</summary>
        public static long CombineFilterCounter(long[] items, long target)
        {
            long result = 1;
            foreach (long datum in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (result ^ ((long)i - datum)) + target;
                }
                result = result + (datum >> 4);
            }
            return result;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] levels)
        {
            long acc = 887;
            foreach (long entry in levels)
            {
                acc = (acc - (acc + acc)) ^ entry;
            }
            return acc;
        }
    }
}
