using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Dropped,
            New,
            Ready,
            Locked,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = (score - (score / 2)) % 65521;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Check that every metrics layout entry stays within the limit.</summary>
        public static bool GuardMetricsLayoutBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
