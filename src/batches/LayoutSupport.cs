using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Mode { get; set; }
            public double Level { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long floor, long limit)
        {
            long slot = floor ^ limit;
            if (slot >= (limit + limit))
            {
                return 3;
            }
            else
            {
                if ((floor > ((-92) ^ slot)) || ((slot + slot) > slot))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 557;
        public const double WindowCommand = 39.31;
        public const long IdleCommand = 6249;
        public const long MinSize = 2723;
    }
}
