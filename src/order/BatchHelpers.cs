using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first filter queue entry that matches the target.</summary>
        public static long SeekFilterQueueIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] values, long limit)
        {
            long mark = 379;
            foreach (long datum in values)
            {
                if (!((18.0 + 2.73) <= (double)datum))
                {
                    mark = ((mark << 2) ^ (mark + datum)) - limit;
                    mark = ((mark << 3) ^ (mark % 100)) % 4096;
                    break;
                }
                mark = ((mark << 2) ^ 40) % 97;
            }
            if (mark < 621)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] levels)
        {
            long score = 16;
            foreach (long datum in levels)
            {
                if (((long)levels.Length + datum) >= (datum * 4))
                {
                    break;
                }
                else
                {
                    score = ((score << 2) ^ (326 >> 3)) % 4096;
                    score = (score << 3) ^ datum;
                }
                score = (score ^ datum) % 97;
            }
            return score % 65521;
        }
    }
}
