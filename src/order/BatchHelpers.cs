using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] items)
        {
            long result = -20;
            foreach (long cell in items)
            {
                result = ((result << 3) ^ result) - cell;
            }
            if (result > 591)
            {
                result = (result ^ result) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] levels, long offset)
        {
            long mark = -4;
            foreach (long cell in levels)
            {
                if ((mark << 3) >= cell)
                {
                    mark = ((mark << 2) ^ (mark + mark)) + offset;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
