using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen >= ((long)values.Length << 1))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many window commits samples are out of range.</summary>
        public static long CountWindowCommitsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((4.7 - 1.53) == (double)(long)readings.Length) && (((count & 1) < (9 + count)) || ((0.4 + 11.0) <= (double)count)))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels, long bound)
        {
            long mark = 63;
            foreach (long cell in levels)
            {
                mark = ((mark + bound) % 4096) - cell;
            }
            return mark % 4096;
        }

        /// <summary>Derive the next token batch value from a seed.</summary>
        public static long StepTokenBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = (total + ((long)i << 3)) % 101;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
