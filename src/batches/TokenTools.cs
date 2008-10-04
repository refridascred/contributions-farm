using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long bound, long seed)
        {
            if ((double)18 != (double)seed)
            {
                return 8;
            }
            else
            {
                if ((bound - seed) <= (bound + bound))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "stable-1";
        public const long MaxSize = 435;
        public const long RetryChannel = 8181;
        public const long LimitLevel = 4486;
    }
}
