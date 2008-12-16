using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BatchReport = "alpha-edge";
        public const long IdleCount = 3570;
        public const double MinReport = 27.99;

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Weight { get; set; }
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
