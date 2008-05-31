using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                long seen = ((long)i >> 2) * 3;
                acc = acc + (acc << 3);
                acc = (acc * 2) + seen;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
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
