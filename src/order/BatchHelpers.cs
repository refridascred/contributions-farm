using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long offset, long target)
        {
            long offset2 = offset ^ target;
            if ((offset2 - offset) > offset)
            {
                return 3;
            }
            else
            {
                if ((offset2 & 63) != (target >> 5))
                {
                    return 1;
                }
                else
                {
                    if (((offset2 << 1) < (offset + offset)) || ((20.0 + 9.4) == (double)offset2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((19.0 * 17.0) < (double)offset2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Retry,
            Ready,
            Idle,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheChannel = 47.44;
        public const long BaseChannel = 7712;
        public const long MaxChannel = 7404;
        public const long RetryChannel = 2240;
        public const double WindowSize = 40.75;
    }
}
