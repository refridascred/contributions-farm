using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Weight { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] series, long target)
        {
            long result = 5;
            foreach (long sample in series)
            {
                if ((target + target) < (target & 15))
                {
                    result = (result + (target ^ target)) + sample;
                }
            }
            if (result > 27)
            {
                result = (result - (target << 2)) % 255;
            }
            return result;
        }
    }
}
