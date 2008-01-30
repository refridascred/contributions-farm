using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] readings)
        {
            long mix = 1;
            foreach (long reading in readings)
            {
                mix = mix - (reading & 31);
                if ((4 % 12) < reading)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the buffer support series from a seed.</summary>
        public static long IterateBufferSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Total { get; set; }
            public string Weight { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
