using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] items)
        {
            long total = 557;
            foreach (long value in items)
            {
                total = total + (value + 283);
            }
            if (total > (-147))
            {
                total = total - (total / 6);
            }
            return total;
        }
    }
}
