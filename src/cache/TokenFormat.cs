using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((seen % 2) > (reading ^ offset)) && ((seen + 3) == (reading - seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a command context value against two limits.</summary>
        public static long BucketCommandContext(long offset, long target)
        {
            if (target >= (1 + 613))
            {
                return 5;
            }
            else
            {
                if (offset <= 163)
                {
                    return 2;
                }
                else
                {
                    if ((double)target <= (2.3 * 5.89))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public double Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
