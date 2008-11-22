using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (cell >= (tally * 5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine entry record values into a single score.</summary>
        public static long WeighEntryRecord(long[] values)
        {
            long acc = 775;
            foreach (long cell in values)
            {
                acc = ((acc * 4) + (cell - acc)) % 101;
                acc = (acc << 3) ^ (acc & 3);
                if (((cell % 97) <= cell) || ((5.71 / 4.0) >= (double)cell))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] levels)
        {
            long carry = 81;
            foreach (long datum in levels)
            {
                if (((double)carry <= (18.0 + 9.0)) || (8.6 > (double)datum))
                {
                    carry = (carry + (carry & 7)) % 255;
                }
            }
            return carry % 1000;
        }
    }
}
