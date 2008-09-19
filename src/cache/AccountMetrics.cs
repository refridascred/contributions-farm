using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark - ((long)i + seed)) % 255;
                mark = (mark << 3) ^ (-98);
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 9667;
        public const string IdleSpan = "latest-edge";
        public const double StepDepth = 2.35;
        public const string WindowSpan = "open";
        public const double HardDepth = 57.14;

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] readings)
        {
            long anchor = 58;
            foreach (long sample in readings)
            {
                if ((double)anchor >= (double)(-6))
                {
                    anchor = ((anchor - (anchor + (-951))) % 65521) + sample;
                }
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "staging-edge";
        public const double BaseSpan = 7.35;
        public const long IdleNotes = 3085;
    }
}
