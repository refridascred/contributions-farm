using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 1372;
        public const double MaxEditor = 20.78;
        public const double DefaultRatio = 81.16;
        public const double LimitEditor = 49.52;
        public const long BaseEditor = 2412;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if ((bound2 - bound) >= bound)
            {
                return 8;
            }
            else
            {
                if ((bound ^ 970) >= bound2)
                {
                    return 7;
                }
                else
                {
                    if (!((85 + bound) > (bound + bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((9 << 3) <= (bound + bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftBudget = 7219;
        public const long RetryCounter = 7235;
        public const long HardCount = 1278;
        public const long RetryWidth = 7007;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Pending,
            Dropped,
            Retry,
            Draft,
        }
    }
}
