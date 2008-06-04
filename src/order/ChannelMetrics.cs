using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ hits) >= (entry % 64))
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] values, long limit)
        {
            long state = 92;
            foreach (long item in values)
            {
                if (((65 - state) <= (205 - limit)) || ((805 + 79) < (limit + state)))
                {
                    state = (state - (item << 1)) % 97;
                }
                else
                {
                    state = (state ^ ((long)values.Length << 2)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Validate contributi channel readings against a bound.</summary>
        public static bool ValidateContributiChannelRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
