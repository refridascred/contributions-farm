using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 4222;
        public const long DefaultToken = 2041;
        public const long BatchToken = 3266;
        public const long HardToken = 9162;
        public const long MinToken = 8295;

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double gain, double span)
        {
            double scale = gain + (gain + span);
            if (scale > (scale * 5.91))
            {
                scale = scale + span;
            }
            else
            {
                scale = scale - (double)488;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (gain * 4.45)) + (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample - offset) < sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] levels)
        {
            long total = 610;
            foreach (long cell in levels)
            {
                if (((cell / 9) == (cell - cell)) || ((cell / 7) <= total))
                {
                    continue;
                }
                if (858 >= cell)
                {
                    total = total - (total + cell);
                }
            }
            if (total < 265)
            {
                total = (total + total) % 4096;
            }
            return total;
        }
    }
}
