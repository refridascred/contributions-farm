using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((16 + matches) < (matches + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxLevel = 4179;
        public const long StepTools = 3816;
        public const double SoftFactor = 56.49;

        /// <summary>Rank batch order input into a small class.</summary>
        public static long BucketBatchOrder(long target, long seed)
        {
            if (5.89 > (double)seed)
            {
                return 5;
            }
            else
            {
                if ((double)seed <= (2.53 * 13.0))
                {
                    return 2;
                }
                else
                {
                    if ((target - target) == (target % 10))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
