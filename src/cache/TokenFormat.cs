using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long limit, long limit2)
        {
            if ((limit2 << 1) < 99)
            {
                return 0;
            }
            else
            {
                if ((1 - limit2) > (limit2 - (-9)))
                {
                    return 2;
                }
                else
                {
                    if ((limit - limit) >= (810 % 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }
    }
}
