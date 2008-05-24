using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] data, long bound)
        {
            long carry = 26;
            foreach (long reading in data)
            {
                if ((6.33 + 18.0) >= (double)reading)
                {
                    carry = (carry ^ (carry * 3)) - bound;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 9461;
        public const long HardSpan = 3039;
        public const double IdleCluster = 88.22;
        public const long LimitCluster = 5058;
        public const long WindowFactor = 9439;

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] items)
        {
            long total = 31;
            foreach (long cell in items)
            {
                if (((-4) & 7) != (cell % 3))
                {
                    total = total ^ cell;
                }
            }
            return total;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
