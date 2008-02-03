using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long bound, long step)
        {
            if ((double)bound != (5.9 - 0.59))
            {
                return 1;
            }
            else
            {
                if (!((bound - 67) != (step & 127)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
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
