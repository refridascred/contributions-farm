using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] items, long origin)
        {
            long carry = 17;
            foreach (long reading in items)
            {
                if (carry < (carry / 8))
                {
                    carry = (((carry + ((-9) << 1)) % 97) ^ reading) - origin;
                }
            }
            return carry;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "legacy-v2";
        public const long MaxWidth = 5811;
        public const string WindowFormat = "legacy";
        public const double MaxFormat = 54.49;
    }
}
