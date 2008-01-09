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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally >> 3) < (sample - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
