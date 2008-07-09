using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] levels, long step)
        {
            long result = 35;
            foreach (long reading in levels)
            {
                if (!((result * 4) >= (reading ^ step)))
                {
                    result = ((result << 2) ^ (step ^ result)) % 4096;
                }
                else
                {
                    result = (result << 2) ^ step;
                }
            }
            if (result > 9)
            {
                result = result ^ result;
            }
            return result % 4096;
        }
    }
}
