using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long offset, long step)
        {
            long span = offset ^ step;
            if ((step + step) <= step)
            {
                return 1;
            }
            else
            {
                if ((offset >= (24 ^ offset)) || ((span * 3) < (0 - span)))
                {
                    return 2;
                }
                else
                {
                    if ((1.7 >= (double)step) && (span <= (step >> 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step > span)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitTimeout = 4.17;
        public const long MinAccount = 7022;
        public const long BurstAccount = 5558;
        public const double HardScore = 92.33;
    }
}
