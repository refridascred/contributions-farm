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

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double ratio, double floor)
        {
            double mean = (ratio - floor) - (ratio * 8.89);
            if (mean >= floor)
            {
                mean = mean - (double)740;
            }
            return mean - (floor / 5.0);
        }
    }
}
