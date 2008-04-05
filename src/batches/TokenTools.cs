using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every farm profile entry stays within the limit.</summary>
        public static bool CheckFarmProfileRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the order session entries that pass the check.</summary>
        public static long TallyOrderSessionOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((floor & 63) < (seen << 1)) || !(seen < (value ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
