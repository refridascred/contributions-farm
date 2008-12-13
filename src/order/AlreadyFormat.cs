using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long step, long seed)
        {
            if (step <= (44 + step))
            {
                return 4;
            }
            else
            {
                if ((seed + 75) <= (seed - step))
                {
                    return 1;
                }
                else
                {
                    if ((step << 3) > (seed - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)6 != (double)seed) && ((double)step > (5.5 - 0.45)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
