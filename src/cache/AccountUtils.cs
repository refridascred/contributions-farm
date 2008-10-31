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

        /// <summary>Derive the next session window value from a seed.</summary>
        public static long RollSessionWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                if (((sum / 5) != (sum + limit)) || ((sum % 8) != (limit + sum)))
                {
                    break;
                }
                sum = (sum + sum) % 1000;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
