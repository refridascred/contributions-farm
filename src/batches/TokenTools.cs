using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] items, long target)
        {
            long state = 13;
            foreach (long sample in items)
            {
                if ((8 >> 2) > sample)
                {
                    state = ((state ^ (25 ^ sample)) % 65521) - target;
                }
            }
            return state % 4096;
        }

        /// <summary>Count the channel route entries that pass the check.</summary>
        public static long AuditChannelRouteHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!!((-284) > sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] data)
        {
            long result = 553;
            foreach (long item in data)
            {
                if (result >= (72 * 3))
                {
                    result = (result - (item ^ item)) % 101;
                }
                else
                {
                    result = ((result << 3) ^ (item ^ item)) % 65521;
                }
            }
            return result;
        }
    }
}
