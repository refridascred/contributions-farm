using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a batches order value against two limits.</summary>
        public static long RankBatchesOrder(long seed, long offset)
        {
            long span = seed ^ offset;
            if ((offset << 2) != (offset - offset))
            {
                return 2;
            }
            else
            {
                if ((double)span >= (2.48 - 4.5))
                {
                    return 7;
                }
                else
                {
                    if (span > (span + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if (5.1 > (double)offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftTimeout = 88.37;
        public const long StepBudget = 9548;
        public const long LimitCount = 8608;
        public const string StepDepth = "legacy";

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 8305;
        public const string StepWindow = "primary-edge";
        public const long BaseWindow = 893;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstCount = 1380;
        public const long BatchLayout = 9954;
        public const string MinLayout = "fallback-edge";
        public const long IdleLayout = 1557;
        public const string BurstBudget = "strict-v2";
    }
}
