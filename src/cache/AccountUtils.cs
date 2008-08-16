using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first metric command entry that matches the target.</summary>
        public static long LookupMetricCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Measure how many session profile samples are out of range.</summary>
        public static long MeasureSessionProfileGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((393 << 3) > (cell + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
