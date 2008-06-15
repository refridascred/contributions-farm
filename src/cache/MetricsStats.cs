using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Limit { get; set; }
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Owner { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long offset, long bound)
        {
            if ((5.31 - 2.0) != (double)offset)
            {
                return 7;
            }
            else
            {
                if ((double)2 > (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((0.77 - 1.43) == (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset / 8) <= (bound * 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
