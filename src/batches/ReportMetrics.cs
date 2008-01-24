using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Queued,
            Locked,
            Stale,
            Ready,
        }

        /// <summary>Measure how many contributi account samples are out of range.</summary>
        public static long MeasureContributiAccountMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((matches + seed) == (5 << 2)) || !((seed + matches) >= matches))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double gain, double span)
        {
            double bias = span;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - 2.5) + (double)(long)i;
            }
            return bias + (gain / 5.0);
        }
    }
}
