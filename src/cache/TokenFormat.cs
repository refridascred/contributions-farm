using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of stats commits entries.</summary>
        public static long ScoreStatsCommits(long[] readings, long target)
        {
            long state = 54;
            foreach (long item in readings)
            {
                if ((state >> 4) > (item * 3))
                {
                    state = ((state << 2) ^ (target >> 5)) % 97;
                }
            }
            return state;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((10.0 / 9.0) < (double)entry) || !((entry * 4) < target))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            New,
            Ready,
        }
    }
}
