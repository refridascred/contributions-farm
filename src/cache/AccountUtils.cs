using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] data)
        {
            long result = 14;
            foreach (long cell in data)
            {
                if ((double)result != (3.54 + 5.23))
                {
                    result = (result ^ (result - result)) % 101;
                }
                if ((94 + result) >= (cell + result))
                {
                    break;
                }
            }
            if (result > 416)
            {
                result = result ^ result;
            }
            return result % 65521;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Pending,
            New,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seed - sample) > (sample - seed))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
