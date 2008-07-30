using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples)
        {
            long mark = 715;
            foreach (long value in samples)
            {
                if (value >= (mark << 3))
                {
                    mark = (mark + (mark + mark)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Accumulate window farm samples.</summary>
        public static long CombineWindowFarm(long[] series, long step)
        {
            long result = 14;
            foreach (long reading in series)
            {
                result = ((result + result) - reading) - step;
            }
            return result;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
