using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Adjust a report graph reading.</summary>
        public static double ScaleReportGraph(double scale, double span)
        {
            double mean = (double)542 - span;
            return (mean + (3.2 / 8.0)) + scale;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
