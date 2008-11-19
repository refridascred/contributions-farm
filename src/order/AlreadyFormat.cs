using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value >= ((long)readings.Length ^ count))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((target * 4) != (target + 32))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] readings, long target)
        {
            long mix = 323;
            foreach (long cell in readings)
            {
                if (((322 << 2) >= (target - mix)) || (7 < (target / 9)))
                {
                    mix = ((mix - (mix + mix)) % 101) ^ cell;
                }
            }
            if (mix > 7)
            {
                mix = ((mix * 3) + (target << 3)) % 101;
            }
            return mix;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((double)tally <= (8.57 / 4.0)) || !((double)value > (7.24 * 14.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
