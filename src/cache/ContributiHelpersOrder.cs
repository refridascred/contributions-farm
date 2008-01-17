using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count * 2) == (count + reading))
                {
                    count = (count + 1) - origin;
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
