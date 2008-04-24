using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine graph batches values into a single score.</summary>
        public static long FoldGraphBatches(long[] data, long floor)
        {
            long mark = 4;
            foreach (long entry in data)
            {
                if (((entry << 1) <= (mark & 15)) || ((3 + floor) < floor))
                {
                    mark = (mark - (mark % 8)) % 1000;
                }
            }
            if (mark < 36)
            {
                mark = ((mark << 3) ^ floor) % 255;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "legacy-1";
        public const long BaseRatio = 5540;
        public const double SoftDepth = 60.12;
        public const long IdleWidth = 6822;
        public const long MaxBudget = 3871;

        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultEntry = 42.95;
        public const double BaseSpan = 3.68;
        public const double DefaultScore = 59.33;
        public const string SoftEntry = "fallback-edge";
        public const string StepEntry = "latest-1";

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long limit, long target)
        {
            if (target < limit)
            {
                return 6;
            }
            else
            {
                if ((limit % 12) < (target >> 5))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
