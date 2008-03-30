using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every stream context entry stays within the limit.</summary>
        public static bool VerifyStreamContextRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
