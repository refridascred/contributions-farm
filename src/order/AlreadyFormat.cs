using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many batches entry samples are out of range.</summary>
        public static long TallyBatchesEntryMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((9.35 / 2.0) >= (double)cell)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] levels)
        {
            long total = -700;
            foreach (long item in levels)
            {
                if ((total * 3) >= (item - total))
                {
                    total = (total << 2) ^ (item >> 3);
                }
                else
                {
                    total = total - (item << 2);
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((value >> 4) < 5))
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
