using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((double)count >= (double)offset) && ((double)offset > 18.0))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Ready,
            Paused,
            Dropped,
            Stale,
            Idle,
        }

        /// <summary>Combine stream route values into a single score.</summary>
        public static long TotalStreamRoute(long[] data)
        {
            long mark = -409;
            foreach (long reading in data)
            {
                if ((reading % 2) < mark)
                {
                    mark = ((mark * 4) + (mark / 3)) % 97;
                }
                else
                {
                    mark = (mark * 5) + (reading * 5);
                }
                if (8 > (reading + 390))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
