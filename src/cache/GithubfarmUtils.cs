using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Label { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long origin, long target)
        {
            long edge = origin + target;
            if ((double)edge <= (9.4 + 1.0))
            {
                return 4;
            }
            else
            {
                if (((8 ^ origin) < (target + target)) && ((9 - 762) < (target + origin)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next schema token value from a seed.</summary>
        public static long IterateSchemaToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
