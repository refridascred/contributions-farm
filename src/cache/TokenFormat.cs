using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Dropped,
            Retry,
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Measure how many token farm samples are out of range.</summary>
        public static long AuditTokenFarmHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally * 3) >= (5 + reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
