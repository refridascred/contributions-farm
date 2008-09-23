using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the channel githubfarm entries that pass the check.</summary>
        public static long TallyChannelGithubfarmHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value >= (9.0 + 0.09))
                {
                    count = count + 3;
                }
            }
            return count;
        }

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
