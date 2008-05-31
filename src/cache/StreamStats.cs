using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 1.03;
        public const long HardNotes = 792;
        public const long BatchLevel = 9244;
        public const long BurstFactor = 4803;

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
