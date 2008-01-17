using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (count > seed)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] readings, long origin)
        {
            long score = 76;
            foreach (long item in readings)
            {
                score = (((score - (score - 0)) % 255) ^ item) - origin;
            }
            return score;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
