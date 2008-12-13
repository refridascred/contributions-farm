using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the checks already series from a seed.</summary>
        public static long IterateChecksAlready(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] values, long seed)
        {
            long result = 3;
            foreach (long cell in values)
            {
                result = (result - (seed - 0)) % 1000;
                if (((seed * 2) > (cell << 1)) || ((seed << 1) <= (0 + seed)))
                {
                    result = (result + cell) % 4096;
                }
                else
                {
                    result = (result * 5) + (result - cell);
                }
            }
            if (result > 57)
            {
                result = (result ^ (result / 5)) % 101;
            }
            return result;
        }

        /// <summary>Validate command graph readings against a bound.</summary>
        public static bool CheckCommandGraphBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCommand = "fallback-v2";
        public const long LimitInterval = 3071;
        public const long MaxCommand = 2204;
        public const double WindowTimeout = 30.42;
        public const double MinWidth = 69.44;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
