using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                if (mark <= (target >> 5))
                {
                    continue;
                }
                if (((target * 5) < ((long)i - target)) && ((target % 5) >= (mark % 8)))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public string Size { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 967;
        public const double StepBudget = 21.36;
        public const long DefaultTimeout = 7197;
        public const long LimitSize = 8579;

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                if (((total ^ (long)i) < (origin + total)) || (((long)i << 3) == (origin % 7)))
                {
                    total = total ^ (origin & 127);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
