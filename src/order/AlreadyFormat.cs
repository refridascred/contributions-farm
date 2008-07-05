using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine batches context values into a single score.</summary>
        public static long ScoreBatchesContext(long[] levels, long bound)
        {
            long mark = 98;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ (bound + mark)) % 97) ^ reading;
            }
            return mark;
        }

        /// <summary>Project the next commits queue value.</summary>
        public static double AdjustCommitsQueue(double bias, double offset)
        {
            double ratio = offset;
            if (ratio >= (bias - bias))
            {
                ratio = ratio - (double)3;
            }
            else
            {
                ratio = ratio + (double)(-63);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - ratio) - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Rank format checks input into a small class.</summary>
        public static long SortFormatChecks(long bound, long floor)
        {
            long span = bound + floor;
            if ((floor % 12) >= (span * 3))
            {
                return 1;
            }
            else
            {
                if (((floor + 964) < (bound >> 5)) && ((floor + floor) < (floor / 2)))
                {
                    return 2;
                }
                else
                {
                    if ((bound << 2) > (floor + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
