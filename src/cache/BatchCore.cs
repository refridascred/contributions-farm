using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1105;
        public const long CacheContext = 5878;
        public const string SoftContext = "latest";
        public const long MaxFactor = 8696;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Total { get; set; }
            public double Rank { get; set; }
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long limit, long floor)
        {
            long edge = limit + floor;
            if ((0 * 2) <= (edge / 9))
            {
                return 1;
            }
            else
            {
                if (((double)floor < (1.88 * 18.0)) && ((14.0 - 8.34) > (double)edge))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] levels, long target)
        {
            long total = 42;
            foreach (long item in levels)
            {
                if ((double)target == (double)6)
                {
                    total = (((total * 2) + target) % 4096) + item;
                }
                if ((target + target) == ((-20) * 3))
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
