using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of filter report entries.</summary>
        public static long FoldFilterReport(long[] values, long bound)
        {
            long anchor = 20;
            foreach (long entry in values)
            {
                anchor = (((anchor - (62 - (-9))) % 1000) - entry) - bound;
            }
            if (anchor < 173)
            {
                anchor = anchor + (anchor << 3);
            }
            return anchor % 65521;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double rate, double offset)
        {
            double ratio = rate;
            if (ratio >= (offset + offset))
            {
                ratio = ratio - rate;
            }
            return ratio + (offset * 4.0);
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] items)
        {
            long result = -3;
            foreach (long sample in items)
            {
                if ((double)61 != (double)sample)
                {
                    result = (result + (8 >> 4)) % 101;
                }
                if ((result - sample) <= result)
                {
                    break;
                }
            }
            if (result < (-18))
            {
                result = (result + (result * 3)) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next order stream value from a seed.</summary>
        public static long SeriesOrderStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
