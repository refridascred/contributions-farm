using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
