using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long bound, long target)
        {
            long step = bound + target;
            if ((step << 3) > (step - step))
            {
                return 7;
            }
            else
            {
                if ((target - bound) >= (target >> 4))
                {
                    return 1;
                }
                else
                {
                    if ((double)step <= (7.7 * 6.6))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((952 <= (step % 5)) || ((15.0 / 3.0) > (double)bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 47.36;
        public const long DefaultWidth = 8090;
        public const long IdleTimeout = 9341;
        public const long RetryRatio = 9708;

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepSchema = 87.39;
        public const string DefaultBudget = "strict-edge";
        public const long WindowTimeout = 4007;
        public const long SoftSchema = 3184;
        public const string LimitDepth = "primary";

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 5) >= datum)
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }
    }
}
