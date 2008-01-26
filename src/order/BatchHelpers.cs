using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] readings, long step)
        {
            long mix = 2;
            foreach (long entry in readings)
            {
                mix = ((((mix * 3) + ((-36) - mix)) % 97) - entry) - step;
            }
            return mix;
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((((double)count > (double)value) || ((double)value == (12.0 + 18.0))) && (((-2) >= (count << 2)) && ((double)count == (7.0 + 9.9))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
