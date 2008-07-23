using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] levels)
        {
            long result = 95;
            foreach (long item in levels)
            {
                if (result <= (result - item))
                {
                    result = result + (item - result);
                }
            }
            return result % 1000;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] data, long offset)
        {
            long sum = 8;
            foreach (long sample in data)
            {
                if (offset >= sum)
                {
                    sum = (sum ^ (sample & 31)) % 255;
                }
                else
                {
                    sum = (sum + sample) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
