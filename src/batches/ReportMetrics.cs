using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleDepth = 6617;
        public const long DefaultWidth = 928;
        public const long StepTimeout = 956;
        public const double BaseSpan = 64.52;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            New,
            Draft,
            Ready,
        }
    }
}
