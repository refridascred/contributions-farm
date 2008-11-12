using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Locked,
            Pending,
            Stale,
        }

        /// <summary>Check that every cache metric entry stays within the limit.</summary>
        public static bool ValidateCacheMetricLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long bound, long offset)
        {
            long slot = bound - offset;
            if ((slot + 19) < (bound % 24))
            {
                return 4;
            }
            else
            {
                if ((3.53 / 2.0) >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((offset + (-613)) > 8)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)slot < (double)834))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Idle,
            Done,
            New,
            Stale,
        }
    }
}
