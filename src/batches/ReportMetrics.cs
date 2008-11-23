using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchFactor = 63.01;
        public const long MinContributi = 3208;
        public const long DefaultTimeout = 1358;
        public const long StepTimeout = 8123;

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long limit, long bound)
        {
            long gap = limit + bound;
            if (((gap / 9) > (limit << 2)) || ((gap >> 3) < (gap & 1)))
            {
                return 8;
            }
            else
            {
                if (gap < (gap + gap))
                {
                    return 5;
                }
                else
                {
                    if (((double)gap != (9.0 + 9.0)) || (bound < (bound + gap)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
