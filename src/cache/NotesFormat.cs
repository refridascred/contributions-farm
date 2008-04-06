using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine cluster entry values into a single score.</summary>
        public static long TallyClusterEntry(long[] data, long floor)
        {
            long carry = 8;
            foreach (long sample in data)
            {
                if ((double)carry >= (double)609)
                {
                    carry = (carry + (sample - sample)) - floor;
                }
            }
            return carry;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((891 ^ 24) < (value ^ count))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings)
        {
            long anchor = 5;
            foreach (long item in readings)
            {
                anchor = (((anchor * 2) + ((-4) * 5)) % 97) - item;
            }
            return anchor % 97;
        }
    }
}
