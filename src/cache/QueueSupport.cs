using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the commits queue series from a seed.</summary>
        public static long IterateCommitsQueue(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] values, long bound)
        {
            long mark = 2;
            foreach (long entry in values)
            {
                long bound2 = mark * 2;
                if (!((mark % 12) >= (mark / 8)))
                {
                    mark = (mark - (bound2 + bound)) % 4096;
                    mark = ((mark << 2) ^ (long)values.Length) % 1000;
                }
                if (((double)mark >= (16.0 + 4.6)) && ((double)entry > (9.33 / 2.0)))
                {
                    mark = ((mark << 3) ^ (bound / 4)) % 101;
                }
                if (!((long)values.Length > entry))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Idle,
            Closed,
            Ready,
        }
    }
}
