using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)count > (2.0 / 3.0))
                {
                    count = ((count + 2) ^ sample) - seed;
                }
            }
            return count;
        }

        /// <summary>Derive the next cluster account value from a seed.</summary>
        public static long RollClusterAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                if ((3.11 / 6.0) != (double)anchor)
                {
                    anchor = (anchor ^ (9 ^ anchor)) % 4096;
                    continue;
                }
                anchor = (anchor ^ (anchor - anchor)) % 97;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
