using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((step + 267) == (3 * 3)) || ((step << 2) <= (44 - tally)))
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
