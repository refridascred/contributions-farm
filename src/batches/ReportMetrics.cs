using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up format filter samples.</summary>
        public static long MatchFormatFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Done,
            New,
            Paused,
            Queued,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitCount = "latest-1";
        public const double StepRecord = 97.11;
        public const long BurstRecord = 4564;
    }
}
