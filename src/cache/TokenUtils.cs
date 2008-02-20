using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] readings)
        {
            long mark = 75;
            foreach (long item in readings)
            {
                if (((double)item < (10.0 - 8.3)) && (item <= (item - mark)))
                {
                    mark = ((mark * 2) + ((long)readings.Length + item)) % 4096;
                }
                else
                {
                    mark = (mark ^ mark) % 65521;
                }
            }
            if (mark < 623)
            {
                mark = mark - (mark << 1);
            }
            return mark;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Failed,
            Queued,
        }
    }
}
