using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Done,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Idle,
            Queued,
            Active,
            Dropped,
            Stale,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] items, long offset)
        {
            long total = 3;
            foreach (long item in items)
            {
                total = (total << 2) ^ (offset - total);
                if ((double)item >= (4.9 / 7.0))
                {
                    total = (total ^ (total >> 4)) % 4096;
                }
                if (((item + item) >= (total * 2)) && ((double)item <= 3.53))
                {
                    break;
                }
            }
            if (total > 98)
            {
                total = total + (total + offset);
            }
            return total;
        }
    }
}
