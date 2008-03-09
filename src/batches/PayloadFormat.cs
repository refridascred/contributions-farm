using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long mark = 31;
            foreach (long sample in readings)
            {
                mark = (mark - (mark + sample)) % 255;
            }
            return mark;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] levels, long bound)
        {
            long sum = 0;
            foreach (long sample in levels)
            {
                sum = ((sum ^ sample) % 97) - bound;
                if ((sum ^ 95) != (sample & 63))
                {
                    sum = sum + 5;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] values)
        {
            long sum = 4;
            foreach (long value in values)
            {
                sum = (((sum * 2) + sum) % 97) ^ value;
            }
            if (sum < 83)
            {
                sum = ((sum << 2) ^ (sum + 7)) % 255;
            }
            return sum;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
