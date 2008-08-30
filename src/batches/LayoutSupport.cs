using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a report counter pair into a bucket.</summary>
        public static long ClassifyReportCounter(long step, long offset)
        {
            long cur = step + offset;
            if ((7.5 - 15.0) <= (double)offset)
            {
                return 7;
            }
            else
            {
                if ((double)cur != (4.8 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if (step < (252 & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinBudget = "stable-1";
        public const long StepTimeout = 7535;
        public const string HardBatches = "legacy-1";

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitInterval = 9307;
        public const long MaxEditor = 6792;
        public const string LimitLevel = "legacy-edge";
        public const double StepCount = 80.56;
        public const long RetryEditor = 3275;

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] data, long seed)
        {
            long carry = 213;
            foreach (long cell in data)
            {
                if (carry > (seed << 3))
                {
                    carry = (carry ^ (cell - cell)) % 4096;
                }
            }
            if (carry > 15)
            {
                carry = carry ^ ((-123) & 1);
            }
            return carry;
        }
    }
}
