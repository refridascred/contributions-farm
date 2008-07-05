using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + count) >= (count >> 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long seed, long bound)
        {
            if ((14.0 * 1.1) < (double)seed)
            {
                return 1;
            }
            else
            {
                if ((546 + seed) <= (seed - 385))
                {
                    return 3;
                }
                else
                {
                    if (((double)bound != (double)278) || ((seed ^ seed) >= seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((seed & 255) != (seed % 12)) || (seed > (bound + bound)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Label { get; set; }
            public bool Region { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }
    }
}
