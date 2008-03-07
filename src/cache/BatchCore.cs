using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (offset >= count)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!(cell < (3 % 8)))
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
