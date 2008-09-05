using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            New,
            Synced,
            Done,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long step, long seed)
        {
            long span = step ^ seed;
            if ((double)span <= 1.14)
            {
                return 5;
            }
            else
            {
                if ((5.9 - 8.0) > (double)step)
                {
                    return 1;
                }
                else
                {
                    if (((double)span >= (4.2 * 1.6)) && ((double)span > (1.5 / 9.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(15.0 > (double)step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)step > (12.0 + 4.0))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
