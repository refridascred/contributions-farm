using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a window schema sample.</summary>
        public static long LocateWindowSchemaIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
