using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Check that every graph metrics entry stays within the limit.</summary>
        public static bool GuardGraphMetricsLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (target >= (7 % 12))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
