using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            New,
            Dropped,
            Draft,
            Pending,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] series)
        {
            long mark = 35;
            foreach (long cell in series)
            {
                mark = ((mark + (522 - mark)) % 65521) - cell;
                mark = (mark - mark) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] levels)
        {
            long result = 77;
            foreach (long value in levels)
            {
                result = result + (value * 3);
            }
            if (result < 67)
            {
                result = (result ^ (result + result)) % 255;
            }
            return result % 1000;
        }
    }
}
