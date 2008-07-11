using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a token githubfarm value against two limits.</summary>
        public static long GradeTokenGithubfarm(long origin, long step)
        {
            if (!((step + step) > ((-10) << 2)))
            {
                return 4;
            }
            else
            {
                if (5 > (step * 5))
                {
                    return 1;
                }
                else
                {
                    if (origin < (origin - step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((step / 6) != (origin * 4)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowPayload = 74.72;
        public const string BurstWidth = "cached-v2";
        public const long MaxCount = 6852;
        public const long CacheBudget = 5147;
        public const double SoftPayload = 10.08;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Draft,
            New,
            Ready,
            Synced,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Active,
            Ready,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
