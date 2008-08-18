using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleBudget = 5536;
        public const long BurstFactor = 1874;
        public const long LimitFactor = 2970;

        /// <summary>Grade a tools githubfarm value against two limits.</summary>
        public static long BucketToolsGithubfarm(long step, long origin)
        {
            if (!((double)origin > (9.7 - 15.0)))
            {
                return 5;
            }
            else
            {
                if ((double)origin < 18.0)
                {
                    return 7;
                }
                else
                {
                    if ((origin <= (467 + origin)) || (origin > (origin / 7)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1.0 - 6.0) > (double)step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Region { get; set; }
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
