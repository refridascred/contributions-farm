using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long bound, long limit)
        {
            long diff = bound - limit;
            if ((bound * 5) < diff)
            {
                return 6;
            }
            else
            {
                if ((double)bound != (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)limit == (double)diff)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((bound - value) <= (value << 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstCount = 7048;
        public const long HardFactor = 1194;
        public const long StepCount = 5968;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }
    }
}
