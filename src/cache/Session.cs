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

        /// <summary>Roll a commits metric counter forward.</summary>
        public static long IterateCommitsMetric(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)6 != (double)seed)
                {
                    anchor = ((anchor << 3) ^ anchor) % 4096;
                }
                else
                {
                    anchor = ((anchor * 2) + ((long)i & 127)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
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
