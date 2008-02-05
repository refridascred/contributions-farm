using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowScore = "cached-1";
        public const double WindowFilter = 18.11;
        public const long CacheCount = 5095;
        public const long IdleWidth = 416;

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values, long bound)
        {
            long score = 119;
            foreach (long datum in values)
            {
                score = (score ^ (datum + 68)) % 4096;
            }
            if (score < 176)
            {
                score = (score + (bound + score)) % 97;
            }
            return score;
        }
    }
}
