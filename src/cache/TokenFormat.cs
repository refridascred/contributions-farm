using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] items, long floor)
        {
            long sum = 77;
            foreach (long value in items)
            {
                if ((double)floor < (double)value)
                {
                    sum = (sum + (floor % 24)) % 101;
                }
                if ((double)floor != (double)value)
                {
                    sum = sum ^ (value + sum);
                }
            }
            return sum % 65521;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long bound, long target)
        {
            long next = bound + target;
            if ((next % 24) <= (bound * 2))
            {
                return 3;
            }
            else
            {
                if ((target + next) > (673 ^ target))
                {
                    return 1;
                }
                else
                {
                    if ((9.88 - 9.99) <= (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
