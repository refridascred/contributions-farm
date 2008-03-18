using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Size { get; set; }
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] samples, long offset)
        {
            long total = 3;
            foreach (long value in samples)
            {
                total = ((total << 2) ^ (offset >> 4)) ^ value;
            }
            return total;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
            public double Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
