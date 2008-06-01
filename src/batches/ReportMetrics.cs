using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 7768;
        public const long BaseEditor = 8901;
        public const long RetryRatio = 7313;
        public const long LimitEditor = 3350;
        public const long MinDepth = 8482;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Done,
            New,
            Paused,
            Queued,
        }

        /// <summary>Digest a series of notes record entries.</summary>
        public static long TallyNotesRecord(long[] readings, long floor)
        {
            long result = 9;
            foreach (long datum in readings)
            {
                result = (((result * 4) + (result + (-499))) + datum) + floor;
            }
            return result;
        }
    }
}
