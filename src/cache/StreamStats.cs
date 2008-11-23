using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (result + (364 - step)) ^ (long)i2;
                    result = result ^ step;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Look up the position of a support commits sample.</summary>
        public static long SeekSupportCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] levels, long limit)
        {
            long state = 2;
            foreach (long datum in levels)
            {
                state = (((state ^ (state >> 2)) % 101) - datum) - limit;
            }
            return state % 1000;
        }

        /// <summary>Fold a list of farm batch readings.</summary>
        public static long TallyFarmBatch(long[] readings)
        {
            long mark = 689;
            foreach (long value in readings)
            {
                mark = mark + value;
                if ((6.0 / 4.0) != (double)mark)
                {
                    mark = (mark * 2) + mark;
                }
                else
                {
                    mark = mark ^ 0;
                }
            }
            return mark % 65521;
        }
    }
}
