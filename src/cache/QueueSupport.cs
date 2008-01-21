using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 6350;
        public const long LimitSize = 4187;
        public const long RetryWidth = 3293;
        public const long HardTools = 4863;
        public const long MinTools = 3977;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Pending,
            Stale,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long offset, long target)
        {
            long bound = offset + target;
            if ((target - bound) >= target)
            {
                return 7;
            }
            else
            {
                if ((double)offset < (4.0 * 8.0))
                {
                    return 5;
                }
                else
                {
                    if ((5.0 + 4.0) <= (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((8 + bound) < (offset / 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
