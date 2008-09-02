using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a window contributi value against two limits.</summary>
        public static long BucketWindowContributi(long limit, long offset)
        {
            long next = limit ^ offset;
            if ((limit >> 1) > (next + offset))
            {
                return 6;
            }
            else
            {
                if (((-86) << 2) <= next)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 4485;
        public const string CacheTools = "open-1";
        public const long MinTools = 9741;
        public const long SoftCount = 6206;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Label { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
