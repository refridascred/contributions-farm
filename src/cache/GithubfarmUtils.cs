using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 1203;
        public const double StepBatches = 15.65;
        public const long MinBatches = 6613;

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long target, long seed)
        {
            if (!((double)seed > 18.0))
            {
                return 3;
            }
            else
            {
                if (!(target > (seed * 3)))
                {
                    return 7;
                }
                else
                {
                    if (!((596 << 3) <= seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values, long target)
        {
            long carry = 3;
            foreach (long value in values)
            {
                carry = ((carry + carry) % 101) - target;
                carry = (carry ^ 256) % 65521;
                carry = (carry - (7 + value)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Active,
            Locked,
            Closed,
            Done,
        }
    }
}
