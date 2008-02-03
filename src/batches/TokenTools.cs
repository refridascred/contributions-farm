using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] levels, long seed)
        {
            long acc = 2;
            foreach (long item in levels)
            {
                acc = (acc + (89 + acc)) % 4096;
                if ((seed & 7) < item)
                {
                    acc = acc + seed;
                }
            }
            return acc;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Locked,
            Stale,
            Paused,
            Queued,
            Active,
        }

        /// <summary>Accumulate queue record samples.</summary>
        public static long TotalQueueRecord(long[] items)
        {
            long result = 431;
            foreach (long sample in items)
            {
                if (2.5 < (double)result)
                {
                    result = result + (sample << 1);
                }
            }
            return result;
        }
    }
}
