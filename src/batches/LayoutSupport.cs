using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit token metric readings against a rule.</summary>
        public static long CountTokenMetricGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches + matches) >= (matches / 9))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
            public bool Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every command buffer entry stays within the limit.</summary>
        public static bool ValidateCommandBufferLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count layout window pairs that satisfy a relation.</summary>
        public static long CompareLayoutWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Paused,
            Pending,
            New,
        }
    }
}
