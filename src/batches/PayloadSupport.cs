using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)seed >= (2.02 * 0.16))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] items, long offset)
        {
            long state = 114;
            foreach (long value in items)
            {
                if (27 <= (offset * 3))
                {
                    state = ((state ^ 0) % 255) + value;
                }
                else
                {
                    state = (state << 2) ^ (offset % 100);
                }
            }
            return state % 4096;
        }
    }
}
