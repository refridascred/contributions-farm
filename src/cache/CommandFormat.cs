using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double ratio, double span)
        {
            double load = (span - ratio) - span;
            if (load < (double)78)
            {
                load = load + 4.0;
            }
            else
            {
                load = load - (double)4;
            }
            return load + (double)(-30);
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many command report samples are out of range.</summary>
        public static long TallyCommandReportMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((46 > (offset & 127)) || ((seen + seen) == (7 + seen))))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }
    }
}
