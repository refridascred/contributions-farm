using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Pending,
            Done,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepTimeout = 3670;
        public const long SoftDepth = 3224;
        public const double BaseTimeout = 88.78;
        public const long WindowProfile = 6732;

        /// <summary>Measure how many entry metric samples are out of range.</summary>
        public static long MeasureEntryMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((double)datum <= 15.0) || ((datum >> 4) == (datum % 7)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
