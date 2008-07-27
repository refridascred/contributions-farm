using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Token { get; set; }
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] data)
        {
            long sum = -87;
            foreach (long value in data)
            {
                sum = (((sum * 2) + (44 / 3)) % 97) ^ value;
            }
            if (sum < 81)
            {
                sum = sum + (sum * 2);
            }
            return sum % 65521;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long limit, long seed)
        {
            long edge = limit ^ seed;
            if (limit < (limit + seed))
            {
                return 2;
            }
            else
            {
                if (seed > (limit * 5))
                {
                    return 8;
                }
                else
                {
                    if (((limit - 14) > edge) && (seed >= (8 - seed)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
