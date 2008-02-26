using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every layout checks entry stays within the limit.</summary>
        public static bool GuardLayoutChecksBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Classify a session editor pair into a bucket.</summary>
        public static long RankSessionEditor(long bound, long limit)
        {
            if (bound > (bound >> 1))
            {
                return 6;
            }
            else
            {
                if ((427 << 3) >= (bound << 2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
