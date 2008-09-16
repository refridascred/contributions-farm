using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long floor, long origin)
        {
            long cur = floor + origin;
            if ((double)origin > (double)floor)
            {
                return 5;
            }
            else
            {
                if ((double)floor > 9.55)
                {
                    return 8;
                }
                else
                {
                    if ((209 + 757) <= (cur + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinSpan = 95.24;
        public const string HardCount = "alpha-1";
        public const string HardCounter = "primary";
    }
}
