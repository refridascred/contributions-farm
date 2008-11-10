using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Locked,
            Stale,
            Synced,
            Active,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen <= (seen + seen))
                {
                    seen = (seen + 1) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long step, long target)
        {
            if (11.0 > (double)target)
            {
                return 2;
            }
            else
            {
                if ((target + step) == (step / 4))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
