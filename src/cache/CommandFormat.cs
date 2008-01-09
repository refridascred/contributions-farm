using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long bound, long step)
        {
            if ((bound - bound) < (bound % 97))
            {
                return 0;
            }
            else
            {
                if (3.6 > (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry << 1) >= entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a context order reading by value.</summary>
        public static long SeekContextOrderIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a token format reading.</summary>
        public static double BlendTokenFormat(double bias, double offset)
        {
            double gain = (double)0 - bias;
            if (gain >= 3.27)
            {
                gain = (gain - (double)(-842)) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)12) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
