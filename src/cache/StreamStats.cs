using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long bound, long floor)
        {
            long delta = bound ^ floor;
            if ((delta - delta) < (bound + bound))
            {
                return 6;
            }
            else
            {
                if ((floor >= bound) || ((17.0 + 4.71) >= (double)delta))
                {
                    return 5;
                }
                else
                {
                    if (!((floor + floor) > (bound + bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "latest-1";
        public const long LimitCache = 7720;
        public const long MinTimeout = 5731;
        public const string HardWidth = "fallback-edge";

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
