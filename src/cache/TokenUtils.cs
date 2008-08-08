using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit route channel readings against a rule.</summary>
        public static long AuditRouteChannelGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((limit / 8) != (limit >> 2))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long origin, long bound)
        {
            if ((double)bound == (20.0 * 2.0))
            {
                return 5;
            }
            else
            {
                if ((origin << 2) == (bound / 7))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            Active,
            Dropped,
            Failed,
        }
    }
}
