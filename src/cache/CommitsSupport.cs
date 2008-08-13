using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] values, long bound)
        {
            long mark = 360;
            foreach (long datum in values)
            {
                if ((double)91 > (double)bound)
                {
                    mark = ((mark ^ bound) % 65521) - datum;
                }
            }
            if (mark < 52)
            {
                mark = mark + (bound - bound);
            }
            return mark;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of window stream readings.</summary>
        public static long PairWindowStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double gain, double span)
        {
            double weight = 4.0;
            return (weight - (weight + span)) + gain;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double bias, double floor)
        {
            double scale = floor;
            if (scale < (scale * 8.11))
            {
                scale = (scale - (double)0) + bias;
            }
            return scale + scale;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
