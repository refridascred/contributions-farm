using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the tools account entries that pass the check.</summary>
        public static long TallyToolsAccountOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((5.6 - 6.0) != (double)bound)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}
